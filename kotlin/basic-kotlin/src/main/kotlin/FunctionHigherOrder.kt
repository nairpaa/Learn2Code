fun hello(value: String, transformer: (String) -> String): String {
    return "Hello ${transformer(value)}"
}

fun main() {
    val upperTransformer = { value: String -> value.toUpperCase() }
    val lowerTransformer = { value: String -> value.toLowerCase() }
    println(hello("Aprian", upperTransformer))
    println(hello("Aprian", lowerTransformer))
}