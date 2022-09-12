// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter five-digit number: ");
string number = Console.ReadLine(); 


void Palindrome5(string text)
{
    int length = text.Length;
    if (length == 5) 
    {
        int start = 0;
        int end = length - 1; 

        while (start < end)
        {
            if (text[start] == text[end])
            {
                start++;
                end--;
            }
            else
            {
                Console.WriteLine("The number isn't palindrom");
                return;
            }
        }
     Console.WriteLine("The number is palindrom");
    } 
    else 
    {
        Console.WriteLine("You entered incorrect number. Enter 5-digit number");
    }
}
Palindrome5(number);