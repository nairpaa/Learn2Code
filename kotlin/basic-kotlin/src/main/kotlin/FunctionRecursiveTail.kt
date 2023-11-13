tailrec fun display(value: Int) {
    println(value)
    if (value > 0) {
        display(value - 1)
    }
}

fun main() {
    display(100)
}