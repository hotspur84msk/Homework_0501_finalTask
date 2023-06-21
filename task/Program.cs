Console.WriteLine("Введите элементы массива: ");
Console.WriteLine("Будут выведены элементы меньше или равные 3 символам");

string a1 = Console.In.ReadLine( );
string a2 = Console.In.ReadLine( );
string a3 = Console.In.ReadLine( );
string a4 = Console.In.ReadLine( );
string a5 = Console.In.ReadLine( );


string[] array1 = new string[5] {a1, a2, a3, a4, a5};
string[] array2 = new string[array1.Length];

void NewArrayChoise(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewArrayChoise(array1, array2);
Console.WriteLine();
PrintArray(array2);