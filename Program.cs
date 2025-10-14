using ConsoleApp1;
using System;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        CollectionsDemo collectionsDemo = new CollectionsDemo();
        collectionsDemo.Start();

        //Subscriber subscriber = new Subscriber();
        //subscriber.Start();

        //int num = 0;
        //Console.Write("Enter A Number: ");
        //num = Convert.ToInt32(Console.ReadLine());

        ////Check Prime
        //if (IsPrime(num))
        //{
        //    Console.WriteLine($"{num} Is A Prime Number.");
        //}
        //else
        //{
        //    Console.WriteLine($"{num} Is Not A Prime Number.");
        //}

        ////Check Pallindrome
        //if(IsPallindrome(num))
        //{
        //    Console.WriteLine($"{num} IS A Pallindrome Number.");
        //}
        //else
        //{
        //    Console.WriteLine($"{num} Is Not A Pallindrome Number.");
        //}

        ////Fibonacci Series
        //Fibonacci(num);

        ////Factorial
        //Factorial(num);

        ////Armstrong Number
        //Armstrong(num);

        ////PrimeFactors
        //PrimeFactors(num);

        ////Reverse A String 
        //Console.Write("Enter A String: ");
        //String str = Console.ReadLine();
        //Reversed(str);

        ////Count Vowels and Consonants
        //CountVowelsAndConsonants(str.ToLower());

        ////Anagram
        //CheckAnagram("Hello", "World");
        //CheckAnagram("Silent", "Listen");

        ////Pyramid
        //Pyramid(10);

        ////Bubble Sorting
        //BubbleSort(new int[] {5, 4, 3, -1, 2, 1});

        ////Words in a string
        //CountWords("My Name Is Jolly Patel");

        ////Remove White Space From A String
        //RemoveSpace("My Name Is Jolly Patel");
  
    }
    //public static void RemoveSpace(String s)
    //{
    //    String newStr = s.Replace(" ", "");
    //    Console.WriteLine($"Spaced Removed: {newStr}");
    //}

    //public static void BubbleSort(int[] arr)
    //{
    //    for(int i = 0;i < arr.Length; i++)
    //    {
    //        for(int j = 0; j < arr.Length - i - 1; j++)
    //        {
    //            if (arr[j] > arr[j + 1])
    //            {
    //                int temp = arr[j];
    //                arr[j] = arr[j + 1];
    //                arr[j + 1] = temp;
    //            }
    //        }        
    //    }
    //    Console.Write("Sorted Array Elements Using Bubble Sort Are: ");
    //    foreach (int i in arr)
    //    {
    //        Console.Write(i + " ");
    //    }
    //    Console.WriteLine();
    //}

    //public static void CountWords(String s)
    //{
    //    String[] array = s.Split(" ");
    //    Console.WriteLine($"There are {array.Length} Words In: {s}.");
    //    Console.WriteLine("Words Are: ");
    //    foreach(String word in array)
    //    {
    //        Console.WriteLine(word);
    //    }
    //}

    //public static bool IsPrime(int num)
    //{
    //    if (num <= 1) return false;
    //    if (num == 2) return true;
    //    for(int i = 2; i <= Math.Sqrt(num); i++)
    //    {
    //        if (num % i == 0) return false;
    //    }
    //    return true;
    //}

    //public static bool IsPallindrome(int num)
    //{
    //    int temp = num;
    //    int result = 0;
    //    while(temp > 0)
    //    {
    //        int last = temp % 10;
    //        result = result * 10 + last;
    //        temp = temp / 10;
    //    }
    //    return result == num;
    //}

    //public static void Fibonacci(int num)
    //{
    //    int a = 0, b = 1;
    //    for(int i = 1; i <= num; i++)
    //    {
    //        Console.Write(a + " ");
    //        int temp = a + b;
    //        a = b;
    //        b = temp;
    //    }
    //    Console.WriteLine();
    //}

    //public static void Factorial(int num)
    //{
    //    long fact = 1;
    //    for(long i = 1; i <= num; i++)
    //    {
    //        fact *= i;
    //    }
    //    Console.WriteLine($"Factorial Of {num} Is {fact}");
    //}

    //public static void Armstrong(int num)
    //{
    //    int length = num.ToString().Length;
    //    int sum = 0;
    //    int temp = num;
    //    for(int i = 0; i < length; i++)
    //    {
    //        sum += (int)Math.Pow((temp % 10), length);
    //        temp /= 10;
    //    }
    //    if(sum == num)
    //    {
    //        Console.WriteLine($"{num} Is Armstrong Number.");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"{num} Is Not A Armstrong Number.");
    //    }
    //}

    //public static void Reversed(String s)
    //{
    //    StringBuilder rev = new StringBuilder();
    //    for(int i = s.Length - 1; i >= 0; i--)
    //    {
    //        rev.Append(s[i]);
    //    }
    //    Console.WriteLine($"{rev.ToString()} Is The Reversed String For {s}");
    //}

    //public static void CountVowelsAndConsonants(String str)
    //{
    //    int consonants = 0, vowels = 0;
    //    foreach(char c in str)
    //    {
    //        if (char.IsLetter(c))
    //        {
    //            if ("aeiou".Contains(c))
    //            {
    //                vowels++;
    //            }
    //            else 
    //            {
    //                consonants++;
    //            }
    //        }
    //    }
    //    Console.WriteLine($"{str} Has {consonants} Consonants And {vowels} Vowels.");
    //}

    //public static void CheckAnagram(String s1, String s2)
    //{
    //    char[] arr1 = s1.ToLower().ToCharArray();
    //    char[] arr2 = s2.ToLower().ToCharArray();
    //    Array.Sort(arr1);
    //    Array.Sort(arr2);
    //    string str1 = new string(arr1);
    //    string str2 = new string(arr2);

    //    if (str1.Equals(str2))
    //    {
    //        Console.WriteLine($"{s1} And {s2} Are Anagrams");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"{s1} And {s2} Are Not Anagrams");
    //    }
    //}

    //public static void PrimeFactors(int num)
    //{
    //    Console.Write($"Prime Factors Of {num} Are: ");
    //    while(num % 2 == 0)
    //    {
    //        Console.Write("2 ");
    //        num /= 2;
    //    }
    //    for(int i = 3; i <= Math.Sqrt(num); i++)
    //    {
    //        while(num % i == 0)
    //        {
    //            Console.Write(i + " ");
    //            num /= i;
    //        }
    //    }
    //    if(num > 2)
    //    {
    //        Console.Write($"{num}");
    //    }
    //    Console.WriteLine();
    //}
    //public static void Pyramid(int num)
    //{
    //    for(int i = 0; i < num; i++)
    //    {
    //        for(int j = 0; j < num - i - 1; j++)
    //        {
    //            Console.Write(" ");
    //        }
    //        for(int j = 0; j <= i; j++)
    //        {
    //            Console.Write("*");
    //        }
    //        for(int j = 0; j < i; j++)
    //        {
    //            Console.Write("*");
    //        }
    //        Console.WriteLine();
    //    }
    //}
}