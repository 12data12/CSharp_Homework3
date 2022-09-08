// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

Console.Write("Enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
string digit = Convert.ToString(number);

if(number >= 10000 && number <= 100000)
{
    if(digit[0]==digit[4] && digit[1]==digit[3])
    {
        Console.WriteLine("Your number is a palindrome.");
    }
    else
    {
        Console.WriteLine("Your number is not a palindrome.");
    }
}
else
{
    Console.WriteLine("The entered number is incorrect. Try again!");
}