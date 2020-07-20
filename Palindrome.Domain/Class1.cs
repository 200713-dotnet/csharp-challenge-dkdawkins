using System;

namespace Palindrome.Domain
{
    public class Class1
    {
      //Code taken from TutorialsPoint Palindrome checker, https://www.tutorialspoint.com/Chash-program-to-check-if-a-string-is-palindrome-or-not#:~:text=After%20that%20use%20the%20equals,mean%20the%20string%20is%20Palindrome.
      //Will write comments on each line because I can't run the code

      static void Main(string[] args)
      {
        string string1, rev; 
        string1 = "Malayalam";
        char[] ch = string1.ToCharArray();
        Array.Reverse(ch);  //These first few lines create a new string, store it in a char array, and reverse the order of characters in the char array
        rev = new string(ch); //Assigns the reversed char array to string rev
        bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
        if (b == true) {
          Console.WriteLine("" + string1 + " is a Palindrome!");
        } else {
          Console.WriteLine(" " + string1 + " is not a Palindrome!");
        }
        Console.Read();
      }
    }
}