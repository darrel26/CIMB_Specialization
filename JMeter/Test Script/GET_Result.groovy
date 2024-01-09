import org.apache.http.client.methods.HttpGet
import org.apache.http.impl.client.HttpClients
import org.apache.http.util.EntityUtils

def httpClient = HttpClients.createDefault()
def request = new HttpGet("https://reqres.in/api/users")
def response = httpClient.execute(request)
def statusCode = response.getStatusLine().getStatusCode()
def responseData = EntityUtils.toString(response.getEntity())

if(statusCode == 200){
    log.info("Response Data : ${responseData}")
    SampleResult.setSuccessful(true)
    log.info("Success to retrieve data! Response Code : ${statusCode}, Responses : ${responseData}")

    SampleResult.setResponseMessage("Success to retrieve data! Response Code : ${statusCode}, Responses : ${responseData}")
} else {
    log.error("Failed to retrieve data. Response Code : ${statusCode}, Responses : ${responseData}")

    SampleResult.setSuccessful(false)
    SampleResult.setResponseMessage("Failed to retrieve data. Response Code : ${statusCode}")
}

httpClient.close()

SampleResult.setResponseData(responseData.getBytes())
SampleResult.setDataType(org.apache.jmeter.samplers.SampleResult.TEXT)
SampleResult.setResponseCode(Integer.toString(statusCode))
