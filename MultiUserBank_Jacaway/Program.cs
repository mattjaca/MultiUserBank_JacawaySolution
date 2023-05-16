// Matthew Jacaway
// IT 112
/* Notes: I don't know if it was necessary to make the decimals in the this class equal to the decimals in the bank class but I remember you saying something about not wanting the user to have direct access to their balances so I defined them privately.
 * Hopefully it wasn't bad that I had the if(balance[i] == 0) and if(balance[i] > 0) statements, because that was the easiest way that I could get rid of the withdrawal option.
 */

// Behaviors:

namespace MultiUserBank_Jacaway
{
    internal class Program
    {
        public static string Options(string options)
        {
            Console.WriteLine("Press 1 to check your balance.");
            Console.WriteLine("Press 2 to make a deposit.");
            Console.WriteLine("Press 3 to make a withdraw.");
            Console.WriteLine("Press 4 to log out.");
            return options;
        }
        public static string Options2(string options)
        {
            Console.WriteLine("Press 1 to check your balance.");
            Console.WriteLine("Press 2 to make a deposit.");
            Console.WriteLine("Press 4 to log out.");
            return options;
        }
        static void Main(string[] args)
        {
            Bank User = new Bank();

            decimal x;
            decimal BankBalance = User.Vault;
            decimal JohnBalance = User.Lennon;
            decimal PaulBalance = User.Mccartney;
            decimal GeorgeBalance = User.Harrison;
            decimal RingoBalance = User.Starr;

            string[] username = { "jlennon", "pmccartney", "gharrison", "rstarr" };
            string[] password = { "johnny", "pauly", "georgy", "ringoy" };
            decimal[] balance = { JohnBalance, PaulBalance, GeorgeBalance, RingoBalance };
            string UserInput = string.Empty;
            string PassInput = string.Empty;
            string answer = string.Empty;

            do
            {
                Console.WriteLine("The current balance of the bank is: " + BankBalance.ToString("c"));
                Console.WriteLine("Press 1 to Login.\nPress 2 to Exit.");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Enter your username.");
                    UserInput = Console.ReadLine();
                    Console.WriteLine("Enter your password.");
                    PassInput = Console.ReadLine();
                }
                else if (answer == "2")
                {
                    return;
                }
                for (int i = 0; i < username.Length; i++)
                {
                    if (username[i] == UserInput && password[i] == PassInput)
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome " + username[i] + " please select an option.");
                        do
                        {
                            if (balance[i] == 0)
                            {
                                Options2(answer);
                                answer = Console.ReadLine();
                            }
                            if (balance[i] > 0)
                            {
                                Options(answer);
                                answer = Console.ReadLine();
                            }
                            if (answer == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("Your current balance is: " + balance[i].ToString("c"));
                            }
                            if (answer == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("Enter the amount that you'd like to deposit.");
                                x = decimal.Parse(Console.ReadLine());
                                BankBalance = User.Deposit(BankBalance, x);
                                balance[i] = User.Deposit(balance[i], x);
                                Console.WriteLine("Your current balance is: " + balance[i].ToString("c"));
                            }
                            if (answer == "3")
                            {
                                Console.Clear();
                                Console.WriteLine("Enter the amount that you'd like to withdraw.");
                                x = decimal.Parse(Console.ReadLine());
                                BankBalance = User.Withdraw(BankBalance, x);
                                balance[i] = User.Withdraw(balance[i], x);

                                Console.WriteLine("Your current balance is: " + balance[i].ToString("c"));
                            }
                            if (answer == "4")
                            {
                                Console.Clear();
                                break;
                            }
                        } while (answer != "4");
                    }
                }
            } while (answer != "2");
        }
    }
}
