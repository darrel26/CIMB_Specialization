def filePath = "D:/Dion/CIMB_Specialization/Batch Scripting/File/TextExample.txt"
def lineCount = 0

new File(filePath).eachLine { line ->
    println "Line ${++lineCount}: ${line}"
}

new File(filePath).eachLine{line ->
    lineCount++
}

println "Jumlah baris di ${filePath} adalah ${lineCount}"
