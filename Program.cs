string [] array1 = new string[5] {"123", "2", "word", ":-)", "ByeBye"};
string [] array2 = new string[array1.Length];

void MyArray(string[] array1, string[] array2)
{
    int size = 0;
    for(int i = 0; i < array1.Length; i ++)
    {
        if(array1[i].Length <= 3)
        {
            array2[size] = array1[i];
            size++;
        }
    }
}

void ShowMyArray(string[] array)
{
    for(int i = 0; i < array.Length; i ++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

MyArray(array1, array2);
ShowMyArray(array2);









