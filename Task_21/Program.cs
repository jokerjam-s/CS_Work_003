/*

Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/

// ввод 
int InputNum(string msg){
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

double Pow2(int n){
    return n * n;
}

int aX, bX, aY, bY, aZ, bZ;


aX = InputNum("Input coordinate X for point A: ");
aY = InputNum("Input coordinate Y for point A: ");
aZ = InputNum("Input coordinate Z for point A: "); 
bX = InputNum("Input coordinate X for point B: ");
bY = InputNum("Input coordinate Y for point B: ");
bZ = InputNum("Input coordinate Z for point B: ");

/*
aX = 7;
aY = -5;
aZ = 0; 
bX = 1;
bY = -1;
bZ = 9;
*/

double distanceX = Pow2(bX - aX);
double distanceY = Pow2(bY - aY);
double distanceZ = Pow2(bZ - aZ);

double S = Math.Sqrt(distanceX + distanceY + distanceZ);

Console.WriteLine($"Distance From A to B is {S}");

