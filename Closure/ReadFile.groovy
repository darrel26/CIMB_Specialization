new File("D:/Dion/CIMB_Specialization/Closure/FileToRead.txt").withReader({ reader ->
    def processorLine = {
        def line = reader.readLine()
        line?.trim()
    }

    def line
    while ((line = processorLine()) != null) {
        println line
    }
})