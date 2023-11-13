fun main() {
    val nilai = "D"

    when(nilai) {
        "A" -> println("Amazing")
        "B" -> {
            println("Good Job")
        }
        "C", "D" -> {
            println("Nice Try")
        }
        else -> {
            println("Try again next year")
        }
    }

    val finalExam = 'A'
    val passValues = arrayOf('A', 'B', 'C')
    when (finalExam) {
        in passValues -> println("Pass")
        !in passValues -> println("Fail")
    }

    val name = "Aprian"
    when (name) {
        is String -> println("Name is String")
        !is String -> println("Name is not String")
    }

    val examValue = 20
    when {
        examValue > 80 -> println("Good Job")
        examValue > 60 -> println("Hahaha")
        else -> println("Sad")
    }
}