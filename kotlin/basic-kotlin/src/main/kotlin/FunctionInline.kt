inline fun hello(name: () -> String): String {
    return "Hello ${name()}"
}

fun main() {
    println(hello { "Aprian"} )
    println(hello { "Muhammad"} )
}