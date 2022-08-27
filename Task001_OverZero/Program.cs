/*
Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

//ввод набора чисел с консоли строкой
int[] ParseArray(string message)
{
Console.WriteLine(message);
string[] nums = Console.ReadLine().Split(new char[] { ',' });
int[] intArray = new int[nums.Length];
for (int i = 0; i < nums.Length; i++)
{
    intArray[i] = int.Parse(nums[i]);
}
 return intArray;

}

//распечатка массива
void PrintArray (int[] col)
{

    int count=col.Length;
    int position=0;

    Console.Write("[ ");
    while(position<count) 
    {
        if(position==count-1)  {Console.Write($"{col[position]}");}
        else {Console.Write($"{col[position]}, ");}
        
        position++;
    }
    Console.WriteLine("] ");

}


int[] FillArray(int size, int min, int max)
{
    int[] array=new int[size];
   
    Random rnd=new Random();

    for(int i=0;i<array.Length;i++)
    {
        array[i]=rnd.Next(min,max+1);
          
    }

    return array;
    
}



int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int ArrPosValues(int[] array)
{
    int answer=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) answer++;
    }

    return answer;
}

int[] array=ParseArray("enter comma separated array values: ");


Console.WriteLine($"In your array there are {ArrPosValues(array)} positive elements. ");

