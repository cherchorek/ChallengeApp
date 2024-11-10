int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
int[] digitCount = new int[10];

// Zliczanie wystąpień cyfr
foreach (char c in letters)
{
    if (c == '0')
    {
        digitCount[0]++;
    }
    else if (c == '1')
    {
        digitCount[1]++;
    }
    else if (c == '2')
    {
        digitCount[2]++;
    }
    else if (c == '3')
    {
        digitCount[3]++;
    }
    else if (c == '4')
    {
        digitCount[4]++;
    }
    else if (c == '5')
    {
        digitCount[5]++;
    }
    else if (c == '6')
    {
        digitCount[6]++;
    }
    else if (c == '7')
    {
        digitCount[7]++;
    }
    else if (c == '8')
    {
        digitCount[8]++;
    }
    else if (c == '9')
    {
        digitCount[9]++;
    }

}

// Wyświetlanie wyników
Console.WriteLine($"Wyniki dla liczby: {number}");
for (int i = 0; i < digitCount.Length; i++)
{
    Console.WriteLine($"Cyfra {i} => {digitCount[i]}");
}