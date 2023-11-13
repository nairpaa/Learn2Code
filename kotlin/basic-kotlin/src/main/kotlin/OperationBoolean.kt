fun main() {
    val nilaiUjian = 80
    val nilaiAbsen = 60

    val apakahLulusUjian = nilaiUjian > 75
    val apakahLulusAbsen = nilaiAbsen > 75

    val apakahLulus = apakahLulusAbsen && apakahLulusUjian
    println(apakahLulus)
}