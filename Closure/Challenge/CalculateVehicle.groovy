def vehicleType

do {
    print "Masukkan jenis kendaraan (Motor/Mobil) : "
    vehicleType = System.in.newReader().readLine()
} while (vehicleType != "Motor" && vehicleType != "Mobil")

println "Masukkan biaya tambahan ([asuransi], [pajak], [admin])"
def additionalCosts = System.in.newReader().readLine()
additionalCosts.split(",");

def calculateTotalCost = { type, listOfCost ->
    def costs = listOfCost.collect({it as int})
    def insuranceCost = costs[0]
    def taxCost = costs[1]
    def adminCost = costs[2]

    def totalCost = insuranceCost + taxCost + adminCost

    return "Total biaya untuk ${type} : Rp. ${totalCost} \nDetail biaya : \nInsurance : ${insuranceCost} \nTax : ${taxCost} \nAdmin : ${adminCost}"
}

println calculateTotalCost(vehicleType, additionalCosts)