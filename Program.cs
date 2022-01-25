Console.Write("Введите строки, символы через запятую: ");
string words = Console.ReadLine();
string[] array = words.Split(',');
string[] newarray = array;

void printarray(string[] newarray)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(array[position] + " ");
        position++;
    }
}
printarray(newarray);