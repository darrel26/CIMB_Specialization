def filePath = "D:/Dion/CIMB_Specialization/Batch Scripting/Challenge/2/Output/OutputLuas"
def outputFile = new File("${filePath}.txt")
def alas
def tinggi
def luas

while (true) {
    print "Masukkan alas : "
    try {
        alas = Integer.parseInt(System.in.newReader().readLine())
    } catch (NumberFormatException e) {
        println "Alas harus berupa angka."
        continue
    }

    print "Masukkan tinggi : "
    try {
        tinggi = Integer.parseInt(System.in.newReader().readLine())
    } catch (NumberFormatException e) {
        println "Tinggi harus berupa angka."
        continue
    }

    if (alas instanceof Integer && tinggi instanceof Integer) {
        break
    }
}

luas = (alas * tinggi) / 2
println "Luas segitiga : ${luas}"

def writeToFile = { writer ->
    outputFile.write("Alas : ${alas}\nTinggi : ${tinggi}\nLuas segitiga : ${luas}")
    println "Hasil perhitungan telah tersimpan ke file ${filePath}"
}

if(!outputFile.exists()){
    if(outputFile.createNewFile()){
        println "File ${filePath} berhasil dibuat!"
        writeToFile(outputFile.newWriter())
    } else {
        println "File ${filePath} gagal dibuat!"
    }
} else {
    println "File ${filePath}.txt sudah ada"
    outputFile = new File("${filePath}_${new Date().format('yyyy-MM-dd_HH-mm-ss')}.txt")
    writeToFile(outputFile.newWriter())
}