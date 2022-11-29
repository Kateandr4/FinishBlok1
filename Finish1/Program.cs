// Написать программу, которая из имеющегося массива 
//строк формирует массив из строк, длина которых меньше либо равна 3 символа.
int GetCount(string[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i].Length<= 3)
        count ++;

    }
    return count;
}

string[] FindString(string[] array, int count)
{
    string[] FindSt;
    FindSt = new string[count];
    int index=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i].Length<= 3)
        {
            FindSt[index]=array[i];
            index++;
        }

    }
    return FindSt;
}

 void PrintArrye(string[] array)
 {
    for ( int i=0; i<array.Length; i++)
    Console.Write($"{array[i]} ");
 }

string[] arrString = {"ghghghg", "gh", "qw466", "88", "nb-", "+8", "244er", "11", "vbf//", "85f", "bv1", "a"};
int CountArr=GetCount(arrString);
string[] FinishArray = FindString(arrString,CountArr);
PrintArrye(FinishArray);
