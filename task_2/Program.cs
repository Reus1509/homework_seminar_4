// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
start:                                          //метка
Console.Clear();

Console.Write("Введите число или 0 чтобы выйти из программы: ");
int number = int.Parse(Console.ReadLine()!);

if(number == 0){
    return;
}

int result = 0;
while(number > 0){
    int dig = number % 10;
    result +=  dig;
    number /= 10;
}
    
Console.WriteLine($"Сумма цифр равна: {result}.");

Thread.Sleep(3000);                             //задержка вывода и повторный запуск программы
goto start;