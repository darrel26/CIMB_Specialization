def sampleResult = prev

// mencetak berbagai informasi tentang sampleResult ke log JMeter
log.info("The Sample Response Code is: " + sampleResult.getResponseCode())
log.info("The Sample Label is: " + sampleResult.getSampleLabel())
log.info("The Start Time in milliseconds is: " + sampleResult.getStartTime())
log.info("The Response Code is: " + sampleResult.getResponseCode())
log.info("The Response Message is: " + sampleResult.getResponseMessage())

sampleResult.setResponseCode("200")