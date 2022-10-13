Console.Clear();

int number1 = GetNumber();
int number2 = GetNumber();
int res = 1;

if (number2 < 0){
    Console.WriteLine("Введено не натуральное число.");
}
else
{
    Console.WriteLine($"Результат возведения числа {number1} в степень {number2} равен: {ExpNumber(number1, number2)}");
}

int GetNumber(){
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
 return number;
}
int ExpNumber(int num1, int num2){
    for(int i = 0; i < num2; i++){
        res *= num1;
    }
    return res;
}
