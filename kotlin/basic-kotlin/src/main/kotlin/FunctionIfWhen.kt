fun sayHello(name: String = ""): String {
    return if (name == "") {
        "Hello Bro!"
    } else {
        "Hello $name"
    }
}

fun sayHello2(name: String = ""): String {
    return when (name) {
        "" -> "Hello Bre!"
        else -> "Hello $name"
    }
}

fun main() {
    println(sayHello(""))
    println(sayHello("Aprian"))

    println(sayHello2(""))
    println(sayHello2("Aprian"))
}