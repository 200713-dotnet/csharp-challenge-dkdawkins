using System;

namespace Palindrome.Domain
{
    public class Class1
    {
      //Code taken from TutorialsPoint Palindrome checker, https://www.tutorialspoint.com/Chash-program-to-check-if-a-string-is-palindrome-or-not#:~:text=After%20that%20use%20the%20equals,mean%20the%20string%20is%20Palindrome.
      static void Main(string[] args)
      {
        Checker();
      }

      public void Checker() 
      {
        string string1, rev; 
        string1 = "Malayalam";
        char[] ch = string1.ToCharArray();
        Array.Reverse(ch);
        rev = new string(ch);
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