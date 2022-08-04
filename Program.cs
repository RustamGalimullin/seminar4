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
int[] arr = {-2,1,7,5,19};
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i<count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        { 
            if (array[j]< array[minPosition]) minPosition = j;
    
    
        }
             int temporary = array [i];
          array [i] =  array[minPosition]; 
          array[minPosition] = temporary; 
    
    }     

}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);