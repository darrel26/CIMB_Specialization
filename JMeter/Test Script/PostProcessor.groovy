import groovy.json.JsonSlurper
import org.apache.jmeter.samplers.SampleResult

SampleResult result = prev

int statusCode = result.getResponseCode() as int
String responseBody = result.getResponseDataAsString()

log.info("The response code is: " + statusCode)
log.info("The response body is: " + responseBody)

def jsonResponse = null
if (statusCode == 200) {
    log.info("Request was successful")

    JsonSlurper jsonSlurper = new JsonSlurper()
    jsonResponse = new JsonSlurper().parseText(responseBody)

    def userId = jsonResponse.data[0].id
    def userName = jsonResponse.data[0].first_name + " " + jsonResponse.data[0].last_name

    log.info("User id : " + userId)
    log.info("User Name : " + userName)

    vars.put("userId", userId.toString())
    vars.put("userName", userName)

    def expectedName = "Michael Lawson"

    if(userName == expectedName) {
        log.info("Validasi nama pengguna berhasil!")
    } else {
        log.error("Validasi nama pengguna gagal!, diharapkan ${expectedName} diterima ${userName}")
    }

    if(jsonResponse.support.text.contains("contributions")) {
        log.info("Validasi teks support berhasil")
    } else {
        log.error("Validasi teks support gagal")
    }

    if(jsonResponse.total_pages > 1) {
        log.info("Ada lebih dari satu halaman hasil")
    } else {
        log.warn("Tidak ada atau hanya ada satu halaman hasil")
    }
} else {
    log.error("Request failed with Status Code : " + statusCode)
}