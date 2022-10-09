// Продолжаем работу с неопределенными массивами

void FillArray(int[] collection) // collection - в данном случае аргумент
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);   // обращаемся к аргументу на позицию индекс и положить туда новое случайное число от 1 до 10 
        index++;
    }
}
void PrintArray(int[] collection2)
{
    int Length2 = collection2.Length;
    int index2 = 0;
    while (index2 < Length2)
    {
        Console.WriteLine(collection2[index2]);
        index2++;
    }
}
int IdexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0; 
    //int position = 0;  изначально было это и все работало отлично
    int position = -1;   // дання запись позволяет присвоить индекс -1 числу которое не попадает в массив
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;            
        }
        index++;
    }
    return position;
}


int[] array = new int[10]; // создать массив с 10 значениями, по умолчанию он создастся с нулями

FillArray(array);
array[4] = 4;    // искуственнов массив добавляем искомый эллемент
array[8] = 4;    // искуственнов массив добавляем искомый эллемент
PrintArray(array);
Console.WriteLine();

//int pos = IdexOf(array, 4);   изначально было это и все работало отлично
int pos = IdexOf(array, 444); // тут мы внесли число для поиска, которое точно находится за пределами массива
Console.WriteLine(pos);

