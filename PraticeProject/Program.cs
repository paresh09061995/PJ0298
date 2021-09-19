using System;
using System.Linq;

namespace PraticeProject
{
   public class Program
    {
       public int number1 = 0;
       public int number2 = 0;

        public void getInputFromUser() {
            Console.WriteLine("Please Enter Number 1:");
            number1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please Enter Number 2:");
            number2 = Convert.ToInt16(Console.ReadLine());
        }

        public string getReverseString(string s)
        {
            char[] str = s.ToCharArray();
            Array.Reverse(str);
            return new string(str);
        }

        //public string removeDuplicates(string input)
        //{
        //    return new string(input.ToCharArray().Distinct().ToArray());
        //}

        public void getMenu() {
            Console.WriteLine("--------------Please select option from below-------------------");
            Console.WriteLine("Press 1 for Addition: ");
            Console.WriteLine("Press 2 for Subtraction: ");
            Console.WriteLine("Press 3 for Multiplication:");
            Console.WriteLine("Press 4 for Division:");
            Console.WriteLine("Press 5 for Reverse String:");
            Console.WriteLine("Press 6 for Palindrome:");
            Console.WriteLine("Press 7 for Duplicate Character from string:");
            Console.WriteLine("Press 8 for Occurrence of each character in a string:");
        }

        static void Main()
        {
            Program obj = new Program();
            char choice;
            string str;
            do
            {
                obj.getMenu();
                Int16 option = Convert.ToInt16(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                        obj.getInputFromUser();
                        Console.WriteLine("Addition is : " + (obj.number1 + obj.number2));
                        break;
                    case 2:
                        obj.getInputFromUser(); 
                        Console.WriteLine("Subtraction is : " + (obj.number1 - obj.number2));
                        break;
                    case 3:
                        obj.getInputFromUser();
                        Console.WriteLine("Multiplication is : " + (obj.number1 * obj.number2));
                        break;
                    case 4:
                        obj.getInputFromUser();
                        Console.WriteLine("Division is : " + (obj.number1 / obj.number2));
                        break;
                    case 5:
                        Console.WriteLine("Enter a string: ");
                        str = Console.ReadLine(); 
                        Console.WriteLine("Reverse string is : " + obj.getReverseString(str));
                        break;
                    case 6:
                        Console.WriteLine("Enter a string to check whether it is Palindrome or not: ");
                        str = Console.ReadLine();
                        Console.WriteLine(str == obj.getReverseString(str) ? str + " is Palindrome" : str + " is not Palindrome");
                        break;
                    case 7:
                        Console.WriteLine("Enter a string to remove duplicate charcter: ");
                        str = Console.ReadLine();
                        var charLookup = str.Where(char.IsLetterOrDigit).ToLookup(c => c);
                        Console.Write("String After Removing Duplicate: ");
                        foreach (var c in charLookup) {
                            if (charLookup[c.Key].Count() == 1) {
                                Console.Write(c.Key);
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine("Enter a string to get occurrence of each character: ");
                        str = Console.ReadLine();
                        var charLookup1 = str.Where(char.IsLetterOrDigit).ToLookup(c => c);
                        foreach (var c in charLookup1)
                            Console.WriteLine("Char:{0} Count:{1}", c.Key, charLookup1[c.Key].Count());
                        break;
                    default:
                        Console.WriteLine("Please select valid option");
                        break;
                }
                Console.WriteLine("Do you want to continue?(y/n)");
                choice = Convert.ToChar(Console.ReadLine());
            } while (Convert.ToString(choice).ToLower() == "y");
        }
    }
}
