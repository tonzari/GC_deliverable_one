using System;
using System.Linq; // I hope it's okay to use LINQ in this assignment!

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init requirements
            int minCharCount = 7;
            int maxCharCount = 12;
            char requiredSpecialChar = '!';
            string successMessage = "Password valid and accepted";
            string failMessage = "Error";
            string userInput = System.String.Empty;

            // Conditional flags
            bool hasLowercase;
            bool hasUppercase;
            bool withinMinRange;
            bool withinMaxRange;
            bool hasRequiredChar;
            bool isValid = false;

            // Main Sequence
            PrintWelcomeMessage();
            GetUserPassword();
            CheckPasswordValidity(userInput);
            if (isValid)
            {
                PrintSuccessMessage();
            }
            else
            {
                PrintFailureMessage();
            }

            #region Methods
            void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome! This simple application will ask you to create a fake password, and will then verify if your password meets a special set of criteria. \n");
                Console.WriteLine("Press any key to continue... \n");
                Console.ReadKey(true);
            }

            void GetUserPassword()
            {
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - \n");
                Console.WriteLine("Your password must contain:");
                Console.WriteLine("- At least one lowercase letter");
                Console.WriteLine("- At least one uppercase letter");
                Console.WriteLine($"- A minimum of {minCharCount} characters");
                Console.WriteLine($"- A maximum of {maxCharCount} characters");
                Console.WriteLine($"- The following special character: {requiredSpecialChar} \n");
                Console.WriteLine("Please type your password now, and press the Enter key to finish.");
                Console.WriteLine("\n - - - - - - - - - - - - - - - - - - - - - - - - \n");
             
                userInput = Console.ReadLine();
            }

            void CheckPasswordValidity(string password)
            {
                hasLowercase = password.Any(char.IsLower);
                hasUppercase = password.Any(char.IsUpper);
                withinMinRange = password.Length >= minCharCount;
                withinMaxRange = password.Length <= maxCharCount;
                hasRequiredChar = password.Contains(requiredSpecialChar);

                if(hasLowercase && hasUppercase && withinMinRange && withinMaxRange && hasRequiredChar)
                {
                    isValid = true;
                }
            }

            void PrintFailureMessage()
            {
                Console.WriteLine("\nYour results: \n");
                Console.WriteLine(failMessage);
                Console.WriteLine("\nPress any key to quit.");
                Console.ReadKey(true);
            }

            void PrintSuccessMessage()
            {
                Console.WriteLine("\nYour results: \n");
                Console.WriteLine(successMessage);
                Console.WriteLine("\nPress any key to quit.");
                Console.ReadKey(true);
            }
            #endregion
        }
    }
}
