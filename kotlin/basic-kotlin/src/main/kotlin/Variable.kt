const val APP = "Belajar Kotlin"
const val VERSION = "0.0.1"

fun main() {
    // mutable = bisa diubah tipe datanya
    var firstName: String? = "Muhammad" // String? == boleh null
    firstName = null
    println(firstName)
    println(firstName?.length) // firstName? == bisa null

    firstName = "Aprian"
    println(firstName.length)

    // immutable = tidak bisa diubah tipe datanya
    val lastName = "Aprian"

    // lastName = "Muhammad Aprian" --> bakal error
    println(lastName)

    // Constant == UPPER_CASE
    println("$APP - $VERSION")
}