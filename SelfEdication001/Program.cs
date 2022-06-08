//Выводит все элементы массива.

/* int[] array = {1, 4, 5, 7, 1, 3, 5, 7};

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
 */

//Выводит все элементы массива в обратном порядке.

/* int[] array = { 1, 4, 5, 7, 1, 3, 5, 7 };

for (int i = array.Length - 1; i >= 0; i--)
{
    Console.WriteLine(array[i]);
} */

//Выводит чётные элементы массива.

/* int[] array = { 1, 4, 5, 7, 1, 3, 5, 7, 6, 2, 7, 10, 24 };
int x = 0;
for (int i = 0; i < array.Length; i++)
{
    x = array[i];
    if (x % 2 == 0)
    {
        Console.WriteLine(x);
    }
} */

// через while
/* int[] array = { 1, 4, 5, 7, 1, 3, 5, 7, 6, 2, 7, 10, 24 };
int i = 0;

while (i<array.Length)
{
    if (array[i] % 2 == 0)
    {
    Console.WriteLine(array[i]);
    i++;
    } else
    i++;
}  */

// Выводит все элементы массива через 1

/* int[] array = { 1, 4, 5, 7, 1, 3, 5, 7, 6, 2, 7, 10, 24, 11 };
int i = 0;

while (i < array.Length)
{
    Console.WriteLine(array[i]);
    i+=2;
} 
 */

// через for

/* int[] array = { 1, 4, 5, 7, 1, 3, 5, 7, 6, 2, 7, 10, 24 };

for(int i = 0; i < array.Length; i += 2)
{
    Console.WriteLine(array[i]);
}
 */


//Выводит все элементы массива пока не встретится элемент -1.

/* int[] array = { 1, 4, 5, 7, 1, 3, 5, -1, 7, 6, 2, 7, 10, 24 };
int index = 0;

while (index < array.Length)
{
    if (array[index] == -1)
    {
        break;
    } else 
        Console.WriteLine(array[index]); Console.Write(index + " index = ");
        index++;
}  */

// через for
/* int[] array = { 1, 4, 5, 7, 1, 3, 5, -1, 7, 6, 2, 7, 10, 24 };

for(int i = 0; i < array.Length; i++)
{
    int element = array[i];

    if (element == -1)
        break;

    Console.WriteLine(element);
}
 */

///Добавление и удаление элементов массива

//В массив добавляется элемент в конец
