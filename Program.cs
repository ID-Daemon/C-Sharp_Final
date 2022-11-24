// Создаем массив и сразу задаем значения, чтоб не парить с вводом с клавиатуры
string[] givenArray = { "тык", "hello", "2", "world", ":-)" };

/* Блок создания массива и его заполнения "с клавиатуры"
Console.Write("Введите количество элементов в массиве: ");
int size = int.Parse(Console.ReadLine()!);
string[] givenArray = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите значение для {i}-элемента массива:");
    givenArray[i] = Console.ReadLine()!;
}
*/

// Переменная для выборки элементов массива по длине
int textLength = 3;

/* Топорное решение
string[] finalArray = new string[givenArray.Length];
for (int i = 0; i < givenArray.Length; i++) if (givenArray[i].Length<=textLength) finalArray[i] = givenArray[i];

Console.WriteLine(String.Join(", ", finalArray));
*/

// "Умное", но не элегантное решение (а все для того, чтобы вывод был ровно так, как в примере показано)
int[] tempArray = SizeCalculation(givenArray);
string[] finalArray = new string[tempArray[0]];
int i = 0;
for (int j = 1; j < tempArray.Length; j++)
{
    if (tempArray[j] == 1)
    {
        finalArray[i] = givenArray[j-1];
        i++;
    }
}

Console.WriteLine(String.Join(", ", finalArray));


int[] SizeCalculation(string[] collection)
{
    int count = 0;
    int[] array = new int[collection.Length + 1];
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i].Length <= textLength)
        {
            count++;
            array[i+1] = 1;
        }
        else array[i+1] = 0;
    }
    array[0] = count;
    return array;
}