// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
// обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

//ввод от пользователя
System.Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[size];
FillArray(stringArray);
PrintArray(newSimbol(stringArray));

void FillArray(string[] stringArray)
{
  for (int i = 0; i < stringArray.Length; i++)
  {
    System.Console.Write($"Введите {i + 1} элемент массива: ");
    stringArray[i] = Console.ReadLine();
  }
}
//проход по каждому элементу массива и проверка длины текущего элемента
string[] newSimbol(string[] stringArray)
{
  int newSize = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length <= 3)
    {
      newSize++;
    }
  }
  // если да, то вносим данные из введенного массива в результат функции. После присвоения увеличивается 
  //переменная j на 1 и возвращается к циклу for в котором i увеличивается на 1
  string[] rezult = new string[newSize];
  int j = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length <= 3)
    {
      rezult[j] = stringArray[i];
      j++;
    }
  }
  return rezult;
}

// выводим элементы массива
void PrintArray(string[] arr)
{
  int arrLeng = arr.Length;
  System.Console.Write("[");
  for (int i = 0; i < arrLeng; i++)
  {
    System.Console.Write($" {arr[i]} ");
  }
  System.Console.Write("]");
}