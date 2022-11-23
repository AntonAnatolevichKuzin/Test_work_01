string[] array = {"if", "for", "else", "{", "<", "while"};
PrintArray(array);
string[] sort_array = GetSortArray(array);
Console.Write(" ->");
PrintArray(sort_array);

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
     {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
     }
    
 }

string[] GetSortArray(string[] array)
{
    int count = 0;
    int length = array.Length;
    string[] res = new string[length];    
    for (int i = 0; i < array.Length; i++)
    {       
        if (array[i].Length <=3)
        {
            res[count] = array[i]; 
            count++;
        } 
    }    
    Array.Resize(ref res, count);
    return res;
}
