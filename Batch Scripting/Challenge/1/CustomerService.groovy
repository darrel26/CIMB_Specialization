def filePath = "D:/Dion/CIMB_Specialization/Batch Scripting/Challenge/CSData.txt"
def lineCount = 0
def layananPinjaman = []
def pembukaanRekening = []
def kartuKredit = []

new File(filePath).eachLine { line ->
    println "Line ${++lineCount}: ${line}"
}