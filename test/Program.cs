//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

void PrinArray(int[] myArray, int i)
{

    if (i == 0)

    {
        Console.Write(myArray[i]);
        return;
    }
    Console.Write(myArray[i] + ", ");
    PrinArray(myArray, i - 1);
}
int[] myArray = { 2, 5, 3 };
int n = myArray.Length - 1;
PrinArray(myArray, n);



