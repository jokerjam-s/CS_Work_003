/*

Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да

*/

// ввод 
int InputNum(string msg){
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

// проверка на полиндром числа
bool PolyndromeFive(int num){
    
    if(num < 0) num = -num;

    string StrNum = num.ToString();
    int counter = 0;
    bool NumIsPolindrome = true;

    while(counter < (StrNum.Length / 2) && NumIsPolindrome){
        if(StrNum[counter] != StrNum[StrNum.Length - 1 - counter]) NumIsPolindrome = false;
        counter++;
    }

    return NumIsPolindrome;
}



int number = InputNum("Input five digits: ");

if(number < 10000 || number > 99999){
    Console.WriteLine("Error! The number is wrong.");
}
else{
    if(PolyndromeFive(number))
        // полиндром
        Console.WriteLine("There is polyndrome.");
    else    
        // не полиндром
        Console.WriteLine("There is not polyndrome.");
}