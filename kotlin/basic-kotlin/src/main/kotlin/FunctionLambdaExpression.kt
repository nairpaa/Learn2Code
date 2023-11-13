fun toLower(value: String): String = value.toLowerCase()

fun main() {
    // membuat lambda
    val lambdaName: (String, String) -> String = { firstName: String, lastName: String ->
        val result = "$firstName $lastName"
        result
    }

    val hurufBesar: (String) -> String = {
        it.toUpperCase()
    }

    // mengeksekusi lambda
    val name = lambdaName("Aprian", "Muhammad")
    println(name)

    println(hurufBesar("aku coba-coba"))

    val toLowerCase: (String) -> String = ::toLower
    println(toLowerCase("APRIAN"))
}