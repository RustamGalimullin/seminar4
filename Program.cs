// See https://aka.ms/new-console-template for more information
///Console.WriteLine("Hello, World!");
void Zadacha25()
{
    Console.WriteLine("введите число A");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число B");
    int b = Convert.ToInt32(Console.ReadLine());
    int number = a;

    for (int i = 1; i < b; i++)
    {
        number = number * a;
    }
    Console.WriteLine("A в степени B равно: " + number);
    
}
///Zadacha25();

///Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Zadacha27()
{
   Console.WriteLine("Введите число");
   int i = Convert.ToInt32(Console.ReadLine());
   int sum = 0; 
   while (i>0)
   {
    int num = i % 10;
    i = i/10;
    sum = sum + num;    
   } 
   
   Console.WriteLine("сумма всех цифр в числе равна: " + sum);
}
///Zadacha27();

 ///Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
void Zadacha29()
{
    int [] numbers = new int [8];
    Console.Write("[");
    for ( int i = 0; i < numbers.Length; i++)
    {
        numbers [i] = new Random(i).Next(0, 100);
        Console.Write("  " + Method (i) + ""); 
    }
    Console.Write("]");

    int Method (int a)
    {
        return numbers[a];
    }
}
Zadacha29();