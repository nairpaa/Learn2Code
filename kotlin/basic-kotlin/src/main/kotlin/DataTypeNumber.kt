fun main() {
    // Integer
    var angka: Int = 200

    println(angka)

    // Float
    var sample: Float = 10.10F

    println(sample)

    // Literals
    var decimalLiteral: Int = 100
    var hexadecimalLiteral: Int = 0xFF
    var binaryLiteral: Int = 0b10101010

    // Underscore
    var age: Byte = 3_0
    var height: Int = 1_7_0
    var price: Long = 9_000_000_000
    println(price)

    // Conversion
    var number: Int = 100

    var byte: Byte = number.toByte();
    var Short: Short = number.toShort();
    var priceInt: Int = price.toInt();

    println(priceInt)

}