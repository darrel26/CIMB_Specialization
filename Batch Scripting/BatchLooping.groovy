def filePath = "D:/Dion/CIMB_Specialization/Batch Scripting/File/LoopingExample.txt"
def newFile = new File(filePath)

if(!newFile.exists()){
    println "File tidak ditemukan : ${filePath}"
} else {
    def outputFile = new File("./Output/ShortLine.txt") // Create the output file
    outputFile.withWriter { writer ->
        newFile.eachLine { line ->
            if(line.length() < 30){
                writer.writeLine(line) // Write the long line to the output file
            }
        }
    }
    println "Lines shorter than 30 characters written to ShortLine.txt"
}
