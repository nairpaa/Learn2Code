fun hitungTotal(name: String, vararg values: Int): Int { // vararg harus dibelakang
    var total = 0

    for (value in values) {
        total += value
    }

    return total
}

fun main () {
    val result = hitungTotal("Ap", 10, 10, 10, 10)

    println(result)
}