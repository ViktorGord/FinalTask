string[] arraySourse = new string[4] {"Hell", "2", "wo", "654"};
string[] arrayFinal = new string[arraySourse.Length];
void ArrayFinal(string[] arraySourse, string[] arrayFinal) {
    int item = 0;
    for (int i = 0; i < arraySourse.Length; i++)
    {
        if (arraySourse[i].Length <= 3)
        {
           arrayFinal[item] = arraySourse[i];
           item++;
        }
    }
}
void PrintArrayFinal (string[] array) {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayFinal(arraySourse, arrayFinal);
PrintArrayFinal(arrayFinal);