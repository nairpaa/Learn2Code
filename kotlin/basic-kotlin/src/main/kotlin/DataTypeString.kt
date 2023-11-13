fun main() {
    var fistName: String = "Muhammad"
    var lastName: String = "Aprian"
    var fullName: String = fistName + " " + lastName
    var fullName2: String = "$fullName $lastName"
    var desc: String = "total $fullName2 adalah ${fullName2.length}"
    var address: String = """
        Streat Not Yet Dont.
        Kumaha              Maneh.
                Urang Lieur.
    """.trimIndent()

    println(fistName)
    println(fullName)
    println(address)
    println(desc)
}