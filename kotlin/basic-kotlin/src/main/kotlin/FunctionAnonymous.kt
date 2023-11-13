fun main() {
    val anonymousUpper = fun(value: String): String {
        if (value.isBlank()) {
            return "Ups"
        }
        return value.toUpperCase()
    }

    val result = hello("Aprian", anonymousUpper)
    println(result)
}