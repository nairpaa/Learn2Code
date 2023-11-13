fun sayHello(firstName: String, lastName: String?) {
    if (lastName == null) {
        println("Hello $firstName!")
    } else {
        println("Hello $firstName $lastName!")
    }
}

fun main() {
    sayHello("Muhammad", "Aprian")
    sayHello("Nairpaa", null)
}