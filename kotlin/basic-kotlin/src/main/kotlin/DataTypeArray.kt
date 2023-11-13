fun main() {
    val members: Array<String> = arrayOf("Eko", "Joko", "Budi")
    val eko: String = members[0]
    val joko: String = members.get(1)
    val budi: String = members.get(2)

    members.set(0, "Amar")

    println(members)
    println(members[0])
}