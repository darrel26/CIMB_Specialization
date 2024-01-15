int jumlahData
double total = 0

while (true) {
    try {
        print "Masukkan jumlah barang yang akan ditambahkan : "
        jumlahData = Integer.parseInt(System.in.newReader().readLine())
        if (jumlahData > 0) {
            for (int i = 1; i <= jumlahData; i++) {
                try {
                    print("Masukkan bilangan ke-$i: ")
                    double bilangan = Double.parseDouble(System.in.newReader().readLine())
                    total += bilangan
                } catch (Exception err) {
                    println "Error: Masukkan harus berupa angka"
                    i--
                    continue
                }
            }
        }
    } catch (Exception err) {
        println "Error: Masukkan harus berupa angka"
        continue
    }
    break
}

double rataRata = total / jumlahData
print("Rata-rata: $rataRata")