import org.apache.jmeter.protocol.http.control.Header;
import org.apache.jmeter.protocol.http.control.HeaderManager;

HeaderManager headerManager = sampler.getHeaderManager();
if (headerManager == null) {
    headerManager = new HeaderManager();
    sampler.addTestElement(headerManager);
}

headerManager.add(new Header("Content-Type", "application/json"));

String queryParam = "page=2";
sampler.setPath(sampler.getPath() + "?" + queryParam);

String protocol = sampler.getProtocol() ?: "http";
String host = sampler.getDomain();
String port = sampler.getPort() > 0 ? ":" + sampler.getPort() : "";
String path = sampler.getPath();
String queryString = sampler.getQueryString().trim() ? sampler.getQueryString().trim() : "";

String fullUrl = "${protocol}://${host}${port}${path}${queryString ? '?' + queryString : ''}";

log.info("Full URL set to:" + fullUrl);