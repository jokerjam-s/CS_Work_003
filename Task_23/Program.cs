/*

Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125

*/

// ввод 
int InputNum(string msg){
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

// степень 3 числа num
double Pow3(int num){
    return num * num * num;
}

int number = InputNum("Input number: ");
int counter = 1;

while(counter < number){
    Console.Write($"{Pow3(counter)}, ");
    counter++;
}

Console.WriteLine(Pow3(number));