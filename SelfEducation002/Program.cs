//Self education


int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int valueToAdd = 10;
int[] largerArray = new int[array.Length + 1];

for (int i = 0; i < array.Length; i++)
{
    largerArray[i] = array[i];
}
largerArray[array.Length] = valueToAdd;
array = largerArray;