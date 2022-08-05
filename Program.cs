// Написать программу, которая из имеющенгося массива строк формирует массив строк, длина которых меньше или равна 3 символа.


// Метод создания пользовательского массива строк из 5 элементов.
string[] GetStringArray(string a, string b,string c,string d,string e) 
{
    string[] result = new string[5] {a,b,c,d,e};
    return result;
}

// Вывод пользовательского массива строк на экран
void PrintStringArray(string[] array)   
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\",");
        
    }  
    Console.Write("]");

}
  
// Вывод элемента массива строк, длина которого меньше или равна 3 символа
void GetThreeSymbolsMassive(string[] array) 
{
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                Console.Write($"\"{array[i]}\",");
            }
        }
        
        
}


