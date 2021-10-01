def accept_operands
    print "Enter your first number: "
    operand1 = gets.to_i
    print "Enter your second number: "
    operand2 = gets.to_i
    [operand1, operand2]
end

loop do 
    puts "--- Your simple calculator in ruby ---"
    puts "1. Addition"
    puts "2. Subtraction"
    puts "3. Multiplication"
    puts "4. Division"
    print "Which operation you want to perform: "

    operation = gets.to_i

    break if operation == 5

    case operation
    when 1
        num1, num2 = accept_operands()
        res = num1 + num2
        puts "#{num1} + #{num2} = #{res}"
    when 2
        num1, num2 = accept_operands()
        res = num1 - num2
        puts "#{num1} - #{num2} = #{res}"
    when 3
        num1, num2 = accept_operands()
        res = num1 * num2
        puts "#{num1} * #{num2} = #{res}"
    when 4
        num1, num2 = accept_operands()
        res = num1.to_f / num2
        puts "#{num1} / #{num2} = #{res}"
    else
        puts "Invalid choice"
    end

    puts ""
end
