string[] arraySourse = new string[4] {"Hello", "2", "world", ":-)"};
string[] arrayFinal = new string[arraySourse.Length];
void ArrayFinal(string[] arraySourse, string[] arrayFinal) {
    int item = 0;
    for (int i = 0; i < arraySourse.length; i++)
    {
        if (arraySourse[i].Length <=3)
        {
           arrayFinal[item] = arraySourse[i];
           i++;
        }
    }
}