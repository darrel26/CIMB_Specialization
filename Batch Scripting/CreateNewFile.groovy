def directoryPath = "./Output"
def fileName = "CreateNewFile.groovy"
def fullPathToFile = "${directoryPath}/${fileName}"
def newFile = new File(fullPathToFile)

if(!newFile.exists()){
    if(newFile.createNewFile()){
        println "File ${fileName} berhasil dibuat!"
    } else {
        println "File ${fileName} gagal dibuat!"
    }
} else {
    println "File ${fullPathToFile} sudah ada"
}
