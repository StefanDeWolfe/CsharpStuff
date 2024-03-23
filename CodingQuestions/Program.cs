using CodingQuestions;


Console.WriteLine("String manipulation:");
Console.WriteLine("");
Console.WriteLine("Reverse String:");
string reverseThis = "Lorem Ipsum";
string reversedString = "muspI meroL";
Console.WriteLine("Reverse String: " + reverseThis);
string reversed = StringManipulation.Reverse(reverseThis);
Console.WriteLine($"Expected Reversed String: {reversedString}");
Console.WriteLine($"Actual Reversed String: {reversed}");
if (reversed.Equals(reversedString))
{
    Console.WriteLine("***Pass\n");
}
else
{
    Console.WriteLine("***Failure\n");
}
Console.WriteLine("String Check for Palendrome:");

string[] nonPalendromeStr = new string[] { "melon", "success" };
string[] palendromeStr = new string[] { "deified", "racecar" };
for (int i = 0; i < nonPalendromeStr.Length; i++)
{
    Console.WriteLine($"String to check: {nonPalendromeStr[i]}");
    Console.WriteLine($"Is Palendrome: {StringManipulation.IsPalendrome(nonPalendromeStr[i])}");
    if (StringManipulation.IsPalendrome(nonPalendromeStr[i]).Equals(false))
    {
        Console.WriteLine("***Pass\n");
    }
    else
    {
        Console.WriteLine("***Failure\n");
    }
}
for (int i = 0; i < palendromeStr.Length; i++)
{
    Console.WriteLine($"String to check: {palendromeStr[i]}");
    Console.WriteLine($"Is Palendrome: {StringManipulation.IsPalendrome(palendromeStr[i])}");
    if (StringManipulation.IsPalendrome(palendromeStr[i]).Equals(true))
    {
        Console.WriteLine("***Pass\n");
    }
    else
    {
        Console.WriteLine("***Failure\n");
    }
}


Console.WriteLine("String Check for Substring:");
string strMain = "Does this contain the substring?";
string strNotContain = "coin";
string strContained = "this";
Console.WriteLine($"Main string: {strMain}");
Console.WriteLine($"Looking for : {strContained}");
if (StringManipulation.ContainsSubstring(strMain, strContained, StringComparison.OrdinalIgnoreCase).Equals(true))
{
    Console.WriteLine("***Pass\n");
}
else
{
    Console.WriteLine("***Failure\n");
}

Console.WriteLine($"Main string: {strMain}");
Console.WriteLine($"Looking for : {strNotContain}");
if (StringManipulation.ContainsSubstring(strMain, strNotContain, StringComparison.OrdinalIgnoreCase).Equals(false))
{
    Console.WriteLine("***Pass\n");
}
else
{
    Console.WriteLine("***Failure\n");
}
Console.WriteLine("");
Console.WriteLine("Number manipulation:");
Console.WriteLine("");
Console.WriteLine("Is Number Prime?:");
Console.WriteLine("");
int[] notPrimes = { -1, 0, 1, 4, 6, 81 };
int[] primes = { 2, 3, 5, 7, 11, 13, 53 };
for (int i =0; i < notPrimes.Length; i++)
{
    bool isPrime = NumberManipulation.IsPrime(notPrimes[i]);
    Console.WriteLine($"Is {notPrimes[i]} Prime?: {isPrime} | Is Correct {isPrime.Equals(false)}");
}
Console.WriteLine("");
for (int i = 0; i < primes.Length; i++)
{
    bool isPrime = NumberManipulation.IsPrime(primes[i]);
    Console.WriteLine($"Is {primes[i]} Prime?: {isPrime} | Is Correct {isPrime.Equals(true)}");
}

Console.WriteLine("");
Console.WriteLine("Singleton Design Pattern:");
Console.WriteLine("");

Singleton s1 = Singleton.Instance;
Singleton s2 = Singleton.Instance;
Console.WriteLine("Is the Singleton the same?: " + (s1 == s2).ToString());


Console.WriteLine("If I set s1.Value to 5, is it 5 for s2?");
Console.WriteLine("Before");
Console.WriteLine("S1.Value = " + s1.Value.ToString());
Console.WriteLine("S2.Value = " + s2.Value.ToString());
s1.Value = 5;
Console.WriteLine("After");
Console.WriteLine("S1.Value = " + s1.Value.ToString());
Console.WriteLine("S2.Value = " + s2.Value.ToString());
Console.WriteLine("Is the S1.Value the same as S2.Value?: " + (s1.Value == s2.Value).ToString());
Console.WriteLine("Thread safe? Creating 5 threads and adding 1 to value in each thread.");
Parallel.ForEach(Enumerable.Range(0,5), i =>
{
    var single = Singleton.Instance;
    single.Value++;
});
Console.WriteLine("S1.Value = " + s1.Value.ToString());
Console.WriteLine("Is the S1.Value now 10?: " + (s1.Value.Equals(10)).ToString());