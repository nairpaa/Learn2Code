fun String.hello(): String {
    return "Hello $this"
}

fun main() {
    val name: String = "Apri"
    val hello: String = name.hello()

    println(hello)
}