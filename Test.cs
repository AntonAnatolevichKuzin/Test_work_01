string[] array = {"if", "for", "else", "{", "<", "while"};
PrintArray(array);
SortArray(array);

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
     {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
     }
    
 }

void SortArray(string[] array)
{
    Console.Write("-> [");
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string temp = array[i];
        int length = temp.Length;
        
        if (length <=2)
        {
            if (count > 0) Console.Write(", ");
        Console.Write($"{array[i]}"); count++;
        }
    }
    Console.Write("]");
}
