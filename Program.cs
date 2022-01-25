Console.Write("Введите символы через запятую: ");
string words = Console.ReadLine();
string[] array = words.Split(','); //задаем исходный массив элементов без запятой.
int index = 0;
for (int i = 0; i < array.Length; i++) //узнаем, сколько необходимо создать элементов в новом массиве.
{
    if (array[i].Length <= 3)
    {
        index++;
    }
}
string[] newarray = new string[index]; //создаем новый массив с необходимым числом элементов.
void sort(string[] col)// метод заполнения нового массива нужными нам элементами.
{
    int length = array.Length;
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[n] = array[i];
            n++;
        }
    }
}
void printarray(string[] arr)// печатаем массив
{
    int count = newarray.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(newarray[position] + " ");
        position++;
    }
}
sort(newarray);
printarray(newarray);