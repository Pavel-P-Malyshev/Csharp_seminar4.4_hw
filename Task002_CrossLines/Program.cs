/*
Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

//ввод набора чисел с консоли строкой
double[] ParseArray(string message)
{
Console.WriteLine(message);
string[] nums = Console.ReadLine().Split(new char[] { ';' });
double[] intArray = new double[nums.Length];
for (int i = 0; i < nums.Length; i++)
{
    intArray[i] = double.Parse(nums[i]);
}
 return intArray;

}



double[] CrossLines(double b1, double k1, double b2, double k2)
{
    double[] coord=new double[2];

    coord[0]=(b2-b1)/(k1-k2);
    coord[1]=k2*((b2-b1)/(k1-k2))+b2;

    return coord;
}

double[] coeff=ParseArray("enter b1,k1,b2,k2:  ");
double[] cross=CrossLines(coeff[0],coeff[1], coeff[2],coeff[3]);
Console.WriteLine($"Crossline coordinates are: x={cross[0]}, y={cross[1]}");