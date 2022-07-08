// See https://aka.ms/new-console-template for more information
Console.WriteLine(IsPalindrome(1)); 
Console.WriteLine(IsPalindrome(-11)); 
Console.WriteLine(IsPalindrome(20));
Console.WriteLine(IsPalindrome(111));

Console.ReadKey();
//static bool IsPalindrome (int x)
//{
//    char[] arr = x.ToString().ToCharArray();

//    for(int i = 0,j = arr.Length -1 ; i < arr.Length; i++, j--)
//    {
//        if (arr[i] != arr[j])
//            return false;

//    }

//    return true;

//}

static bool IsPalindrome(int n)
{
    if (n < 0 || (n % 10 == 0 && n != 0))
        return false;

    int x = 0, t = n;

    while(t != 0)
    {
        x = x * 10 + t % 10;
        t /= 10;
    }

    return x == n;

}