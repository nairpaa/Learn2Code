fun printHello(name: String?): Unit { // "Unit" tidak wajib ditulis. "Unit" seperti void
    if (name == null) {
        println("Hello bro!")
    } else {
        println("Hello $name!")
    }
}

fun main() {
    printHello("Aprian")
    printHello(null)
}