import java.util.*

fun main(args: Array<String>) {
    val reader = Scanner(System.`in`)
    print("Enter two numbers: ")

    val first = reader.nextDouble()
    val second = reader.nextDouble()

    print("Enter an operator (+, -, *, /): ")
    val operator = reader.next()[0]

    val result: Double

    when (operator) {
        '+' -> result = first + second
        '-' -> result = first - second
        '*' -> result = first * second
        '/' -> result = first / second

        else -> {
            System.out.printf("Error! operator is not correct")
            return
        }
    }

    System.out.printf("%.1f %c %.1f = %.1f", first, operator, second, result)
}