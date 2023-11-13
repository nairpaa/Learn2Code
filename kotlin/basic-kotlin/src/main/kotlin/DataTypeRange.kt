fun main() {
    val range = 1..100
    println(range)
    println(range.count())
    println(range.contains(50))
    println(range.contains(200))
    println(range.first)
    println(range.last)
    println(range.step)

    val range2 = 100 downTo 1 step 2
    println(range2.count())
    println(range2.first)
    println(range2.last)
    println(range2.step)
}