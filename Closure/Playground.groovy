def penambahan = {a, b ->
    return a + b
}

println penambahan(1, 2)
println penambahan("1", 2)

// Closure dapat mengakses external variable
def externalVar = 10
def accessToExtVar = {println externalVar}
accessToExtVar()
externalVar = 20
accessToExtVar()