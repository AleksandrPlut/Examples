// МЕТОДЫ
// Метод 1. Ни чего не принимает и ни чего не возвращает.
/*
void Method1()  // Method1 - это именование, по сути можно назвать как угодно
{
    Console.WriteLine("Автор, Plut"); // тело метода
}
Method1();   // то как вызывается это метод, просто обращением к его названию и круглые скобки в конце
*/

// Метод 2. Что то принимают, но ни чего не возвращают.
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения"); //msg: - в случае есле у нас несколько аргументов то "msg:" показывает какой аргумент мы хотим видеть.


void Method2_1(string msg, int count)
{
    int i =0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method2_1("Текст", 4);
Method2_1(count: 4, msg: "новый текс"); // можно писать как тут, а можно писать как в варианте 29 строки, и не обязательно по порядку
*/

// Метод 3. Ни чего не принимают, но что то возвращают.
/*
int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
Console.WriteLine(Year);
*/

// Метод 4. Что то принимают и что то возвращают
/*
string Method4 (int count, string c)
{
    int i = 0;
    string result = ""; // после знака присвоения пустая строка " ", так же вместо ковычек может быть написано String.Empty (что в переводе тоже означает пустая строка)

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "asd ");
Console.WriteLine(res);
*/

// Четвертый метод сделаем через цикл for, а цикл while уберем
/*
string Method4 (int count, string c)
{
    
    string result = ""; 
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

string res = Method4(5, "asd ");
Console.WriteLine(res);
*/

// Демострация цикла в цикле. 
// На примере таблици умножения
/*
for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine();    // пустая строка, для большей наглядности
}
*/

// ====== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к", заменить большими "К",
// а большие "С", заменить маленькими "с".
/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// Примечание
// string s = "qwerty"
//             0123
// s [3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i=0; i<length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
*/

// Упорядочивание массива от минимального числа к максимальному
/*
int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j<array.Length; j++)
        {
            if (array[j] < array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
*/

// Пытаемся отсортировать от максимального к минимальному самостоятельно
int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j<array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);


