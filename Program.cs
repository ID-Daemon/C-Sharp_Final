// Создаем массив и сразу задаем значения, чтоб не парить с вводом с клавиатуры
string[] givenArray = {"hello", "2", "world", ":-)"};

/* Блок создания массива и его заполнения с клавиатуры
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

/* "Топорное решение
string[] finalArray = new string[givenArray.Length];
for (int i = 0; i < givenArray.Length; i++) if (givenArray[i].Length<=textLength) finalArray[i] = givenArray[i];

Console.WriteLine(String.Join(", ", finalArray));
*/

