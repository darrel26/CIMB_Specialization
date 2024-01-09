class JMeterHelper {
    private def vars
    private def log

    JMeterHelper(def vars, def log) {
        this.vars = vars
        this.log = log
    }

    void setVars(String name, String value) {
        vars.put(name, value)
    }

    String getVars(String name) {
        return vars.get(name)
    }

    void logVars(String name) {
        String value = getVars(name)
        log.info("The value of ${name} is ${value}")
    }
}

def helper = new JMeterHelper(vars, log)

helper.setVars("Hello JMeter", "Hello Dion!")

helper.logVars("Hello JMeter")