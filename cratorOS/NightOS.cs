using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Drawing;
namespace CratorOS
{
    class Program
    {

        //Programming Language Start
        public static craterOStextCommands Text = new craterOStextCommands();
        public class craterOStextCommands
        {

            //Random command in programming language "Generate Random Digit"
            public void Rand(int RangeY, int RangeX)
            {
                Random randomDigit1 = new Random();
                int randomNumber = randomDigit1.Next(RangeY, RangeX);
            }
            //Random command in programming language "Generate Random Digit" And Prints Message
            public void RandSay(int RangeY, int RangeX)
            {
                Random randomDigit1 = new Random();
                int randomNumber = randomDigit1.Next(RangeY, RangeX);
                Console.WriteLine("the number was:" + randomNumber);
            }
            //Shuts oof system and allows custom message
            public void ShutDown(string shutDownMessage)
            {
                Console.Clear();
                Console.WriteLine(shutDownMessage);
                Console.ReadLine();
                Environment.Exit(0);
            }
            public void ErrorHandler(string errorMessage)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(errorMessage);
                Console.WriteLine("----------------------------------------------");
                Console.ReadLine();
                Environment.Exit(0);
            }
            //Show Developers/Testers - Allows message input
            public void Credits(string developerMessage)
            {
                Console.WriteLine("Developed By @ITS_N1GH7OWL, @JavaBoi, And Tested By @Mega_Danz");
                Console.WriteLine(developerMessage);
            }
            //add program call
            public void Add(int X, int Y)
            {
                int totalSum = X + Y;
                Console.WriteLine(X + " + " + Y + " = " + totalSum);
            }
            //subtract program call
            public void Subtract(int X, int Y)
            {
                int totalSum = X - Y;
                Console.WriteLine(X + " - " + Y + " = " + totalSum);
            }
            //multiply program call
            public void Multiply(int X, int Y)
            {
                int totalSum = X * Y;
                Console.WriteLine(X + " x " + Y + " = " + totalSum);
            }
            //Divide program Call
            public void Divide(int X, int Y)
            {
                int totalSum = X / Y;
                Console.WriteLine(X + " / " + Y + " = " + totalSum);
            }
            //Sad textbox!! :(
            public void TextBox(string words)
            {
                Console.WriteLine("|" + words + "|");
            }
            //Screen Write function named SayNX for programming language
            public void SayNX(string words)
            {
                Console.WriteLine(words);
            }
            //Its sad brother to writeNX Wishes it could make new lines
            public void Say(string words)
            {
                Console.Write(words);
            }
            //this reads things, basically the only thing its good at in life
            public void Read()
            {
                Console.ReadLine();
            }
            public string ReadInput()
            {
                return Console.ReadLine();
            }
            //Clears Text Above
            public void Clean()
            {
                Console.Clear();
            }
            //Color Libary for new programming language inside OS
            public void Color(string color)
            {
                if (color == "Red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (color == "Blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (color == "Green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (color == "Yellow")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (color == "Black")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (color == "White")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (color == "Gray")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            public static void mainMenu()
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Welcome To CratorOS!\nDeveloped By @ITS_N1GH7OWL, @JavaBoi, And Tested By @Mega_Danz");
                Console.WriteLine("||||Version 0.1 UPDATE TEST||||");
                Console.WriteLine("_______________________________");
                string dateString = DateTime.Today.ToShortDateString() + "    |";
                Console.WriteLine("Hello! Today is " + dateString);
                Console.WriteLine("Please Choose An Option:      |");//Choosing Options for the OS
                Console.WriteLine("(1)Open Game Development SDK  |");
                Console.WriteLine("(2)Calculator                 |");
                Console.WriteLine("(3)Browser                    |");
                Console.WriteLine("(4)Number Game                |");
                Console.WriteLine("(5)Text Editor                |");
                Console.WriteLine("(6)CratorOS Command Line      |");
                Console.WriteLine("(7)Text Game                  |");
                Console.WriteLine("(8)To-Do List                 |");
                Console.WriteLine("(9)Shut Down                  |");
                Console.WriteLine("(10)Check For Updates...      |");
                Console.WriteLine("______________________________|");
                Console.Write("Please Enter A Digit: ");
                string choice = Console.ReadLine();//User Input
                Console.WriteLine("");
                //Choice Option Arrays
                string[] choiceOptions = new string[10];
                choiceOptions[0] = "1"; choiceOptions[1] = "2"; choiceOptions[2] = "3"; choiceOptions[3] = "4"; choiceOptions[4] = "5"; choiceOptions[5] = "6"; choiceOptions[6] = "7"; choiceOptions[7] = "8";
                choiceOptions[8] = "9"; choiceOptions[9] = "10";
                //Game Development SDK caller
                if (choice == choiceOptions[0])
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("Has Not Been developed Yet\n<Press Any Key To Go Back>");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    mainMenu();
                }
                //Calculator caller
                else if (choice == choiceOptions[1])
                {
                    Calculator();
                }
                //Open page from Browers(Though at the moment it only works on Windows)
                else if (choice == choiceOptions[2])
                {
                    browser();
                }
                //Number game caller
                else if (choice == choiceOptions[3])
                {
                    numberGame();
                }

                else if (choice == choiceOptions[4])
                {
                    textEditor();
                }
                //Shut Down!
                else if (choice == choiceOptions[5])
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("Has Not Been developed Yet\n<Press Any Key To Go Back>");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    mainMenu();
                }
                else if (choice == choiceOptions[6])
                {
                    TextGame();
                }
                else if (choice == choiceOptions[7])
                {
                    ToDoList();
                }

                else if (choice == choiceOptions[8])
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Are You Sure?(Y/N): ");
                    Console.ResetColor();
                    string closeOSInput = Console.ReadLine();
                    if (closeOSInput == "Y" || closeOSInput == "y")
                    {
                        Environment.Exit(0);
                    }
                    else if (closeOSInput == "N" || closeOSInput == "n")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        mainMenu();
                    }
                }
                else if (choice == choiceOptions[9])
                {
                Console.WriteLine("Welcome To Update Manager!\pPress Any Key To Update To latest Version...");
                Console.ReadKey();
                WebClient Client = new WebClient ();
                Client.DownloadFile("https://teamnightowl.ca/cratorOS/nightOS.cs", @"NightOS.cs");
                }

                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("That is not a valid choice.\n<Press Any Key to Go Back>");
                    Console.WriteLine("----------------------------------------------");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    mainMenu();
                }

            }
            //MainMenu of the OS ending

            //Text Game begging
            public static void whatHappened()
            {
                Random randomDigit2 = new Random();
                int randomNumber2 = randomDigit2.Next(1, 11);
                if (randomNumber2 == 1)
                {
                    Console.WriteLine("You fall down a hole and lose 2 health");
                }
                if (randomNumber2 == 2)
                {
                    Console.WriteLine("You meet a friend and talk for a while and get nothing");
                }
                if (randomNumber2 == 3)
                {
                    Console.WriteLine("You fall down a hole and lose 2 health");
                }
                if (randomNumber2 == 4)
                {
                    Console.WriteLine("You fall down a hole and lose 2 health");
                }
                if (randomNumber2 == 5)
                {
                    Console.WriteLine("You fall down a hole and lose 2 health");
                }
                if (randomNumber2 == 6)
                {
                    Console.WriteLine("You fall down a hole and lose 2 health");
                }

            }
            //Text Game for User To Play
            public static void TextGame()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The Great Disappearence Of Neo York");
                Console.WriteLine("---Written By: Mega_Danz-------");
                Console.WriteLine("---------------------------------------------------------------");
                Console.Write("Press any Key to Continue...");
                Console.ReadKey();
                Console.Write("What is your name, OFFICER?: ");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Hello, " + name);
                Console.Write("Mr.Boss: A Case Has Just Come Up, " + name + ", 2000 poverts have just gone missing. Will you take it?(Y/N): ");
                string continueGame = Console.ReadLine();
                if (continueGame == "Y" || continueGame == "y")
                {
                    Console.Clear();
                    Console.WriteLine("You head out to the poor side of the city, \nWith homeless left all over the streets.");
                    Console.ReadKey();
                    //Continue Game
                }
                else if (continueGame == "N" || continueGame == "n")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your Been Revoked From Your Duty's...in other words...Your fired.");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    mainMenu();
                }
                Console.ReadLine();
                Console.Clear();

            }
            //Calculator Method
            private static void Calculator()
            {
                Console.Clear();
                Console.WriteLine("What operation would you like to do?");
                Console.WriteLine("(1)Addition.");
                Console.WriteLine("(2)Subtraction.");
                Console.WriteLine("(3)Multiplaction.");
                Console.WriteLine("(4)Division.");
                string choice = Console.ReadLine();
                string[] choiceOperations = new String[4];
                choiceOperations[0] = "1"; choiceOperations[1] = "2"; choiceOperations[2] = "3"; choiceOperations[3] = "4";
                //Addition Part
                if (choice == choiceOperations[0])
                {
                    Console.WriteLine("Welcome to the Addition Calculator");
                    Console.Write("Insert Your first number: ");
                    string userAnswer = Console.ReadLine();
                    float InputInt = float.Parse(userAnswer);
                    Console.WriteLine(InputInt + " + " + " ? " + " = ?");
                    Console.Write("Insert Your Second number: ");
                    string userAnswer2 = Console.ReadLine();
                    float InputInt2 = float.Parse(userAnswer2);
                    float userAnswerAdded = InputInt + InputInt2;
                    Console.WriteLine("The answer is: " + InputInt + " + " + InputInt2 + " = " + userAnswerAdded);
                    Console.ReadLine();
                    Console.Clear();
                    mainMenu();
                }
                //Subtraction Part
                else if (choice == choiceOperations[1])
                {
                    Console.WriteLine("Welcome to the Subtraction Calculator");
                    Console.Write("Insert Your first number: ");
                    string userAnswer = Console.ReadLine();
                    float InputInt = float.Parse(userAnswer);
                    Console.WriteLine(InputInt + " - " + " ? " + " = ?");
                    Console.Write("Insert Your Second number: ");
                    string userAnswer2 = Console.ReadLine();
                    float InputInt2 = float.Parse(userAnswer2);
                    float userAnswerAdded = InputInt - InputInt2;
                    Console.WriteLine("The answer is: " + InputInt + " - " + InputInt2 + " = " + userAnswerAdded);
                    Console.ReadLine();
                    Console.Clear();
                    mainMenu();
                }
                //Multiplaction Part
                else if (choice == choiceOperations[2])
                {
                    Console.WriteLine("Welcome to the Multiplaction Calculator");
                    Console.Write("Insert Your first number :");
                    string userAnswer = Console.ReadLine();
                    float InputInt = int.Parse(userAnswer);
                    Console.WriteLine(InputInt + " x " + " ? " + " = ?");
                    Console.Write("Insert Your Second number: ");
                    string userAnswer2 = Console.ReadLine();
                    float InputInt2 = float.Parse(userAnswer2);
                    float userAnswerAdded = InputInt * InputInt2;
                    Console.WriteLine("The answer is: " + InputInt + " x " + InputInt2 + " = " + userAnswerAdded);
                    Console.ReadLine();
                    Console.Clear();
                    mainMenu();
                }
                //Division Part
                else if (choice == choiceOperations[3])
                {
                    Console.WriteLine("Welcome to the Division Calculator");
                    Console.Write("Insert Your first number: ");
                    string userAnswer = Console.ReadLine();
                    float InputInt = float.Parse(userAnswer);
                    Console.WriteLine(InputInt + " / " + " ? " + " = ?");
                    Console.Write("Insert Your Second number: ");
                    string userAnswer2 = Console.ReadLine();
                    float InputInt2 = float.Parse(userAnswer2);
                    float userAnswerAdded = InputInt / InputInt2;
                    Console.WriteLine("The answer is: " + InputInt + " / " + InputInt2 + " = " + userAnswerAdded);
                    Console.ReadLine();
                    Console.Clear();
                    mainMenu();
                }
            }
            //Calculator End!

            //Text editor


            private static void browser()
            {
                Console.Clear();
                Console.WriteLine("Welcome To The CratorOS Browser!");
                Console.Write("Please Enter A Name, Which We Can Find A URL For: ");
                Console.WriteLine("(1)com");
                Console.WriteLine("(2)ca");
                Console.WriteLine("(3)org ");
                Console.WriteLine("(4)net");
                Console.WriteLine("(5)io");
                Console.WriteLine("(6)us");
                Console.WriteLine("(7)custom");
                Console.Write("Please Enter One Of The Digits Above Here: ");
                string urlType = Console.ReadLine();

                if (urlType == "1")
                {
                    Console.WriteLine("Please Enter Your Search Results Below\nPlease Enter Url(Doesnt Need Http://WWW.UserInput.COM)\nWill Search For A Website With The URL Name\nExample:Google ---- Which Will Search For https://google.com/");
                    Console.Write("Enter URl Search here: ");
                    string searchResultInput = "www." + Console.ReadLine() + ".com/";
                    Process.Start(searchResultInput);
                }
                else if (urlType == "2")
                {
                    Console.WriteLine("Please Enter Your Search Results Below\nPlease Enter Url(Doesnt Need Http://WWW.UserInput.COM)\nWill Search For A Website With The URL Name\nExample:Google ---- Which Will Search For https://google.com/");
                    Console.Write("Enter URl Search here: ");
                    string searchResultInput = "www." + Console.ReadLine() + ".ca/";
                    Process.Start(searchResultInput);
                }
                else if (urlType == "3")
                {
                    Console.WriteLine("Please Enter Your Search Results Below\nPlease Enter Url(Doesnt Need Http://WWW.UserInput.COM)\nWill Search For A Website With The URL Name\nExample:Google ---- Which Will Search For https://google.com/");
                    Console.Write("Enter URl Search here: ");
                    string searchResultInput = "www." + Console.ReadLine() + ".org/";
                    Process.Start(searchResultInput);
                }
                else if (urlType == "4")
                {
                    Console.WriteLine("Please Enter Your Search Results Below\nPlease Enter Url(Doesnt Need Http://WWW.UserInput.COM)\nWill Search For A Website With The URL Name\nExample:Google ---- Which Will Search For https://google.com/");
                    Console.Write("Enter URl Search here: ");
                    string searchResultInput = "www." + Console.ReadLine() + ".net/";
                    Process.Start(searchResultInput);
                }
                else if (urlType == "5")
                {
                    Console.WriteLine("Please Enter Your Search Results Below\nPlease Enter Url(Doesnt Need Http://WWW.UserInput.COM)\nWill Search For A Website With The URL Name\nExample:Google ---- Which Will Search For https://google.com/");
                    Console.Write("Enter URl Search here: ");
                    string searchResultInput = "www." + Console.ReadLine() + ".io/";
                    Process.Start(searchResultInput);
                }
                else if (urlType == "6")
                {
                    Console.WriteLine("Please Enter Your Search Results Below\nPlease Enter Url(Doesnt Need Http://WWW.UserInput.COM)\nWill Search For A Website With The URL Name\nExample:Google ---- Which Will Search For https://google.com/");
                    Console.Write("Enter URl Search here: ");
                    string searchResultInput = "www." + Console.ReadLine() + ".us/";
                    Process.Start(searchResultInput);
                }
                else if (urlType == "7")
                {
                    Console.Write("Please Enter End Of URL (Example:[example.-->COM<--]): ");
                    string customUrlEnding = Text.ReadInput();
                    Console.WriteLine("Please Enter Your Search Results Below\nPlease Enter Url(Doesnt Need Http://WWW.UserInput.COM)\nWill Search For A Website With The URL Name\nExample:Google ---- Which Will Search For https://google.com/");
                    Console.Write("Enter URl Search here: ");
                    string searchResultInput = "www." + Console.ReadLine() + "." + customUrlEnding;
                    Process.Start(searchResultInput);
                }

                mainMenu();
            }
            //To-Do List
            public static void ToDoList()
            {
                int line = 1;
                string colin = ".";
                bool writing = true;
                Console.WriteLine("Welcome to the To-Do List");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("type exit to leave the ToDoList");
                Console.Write("Please Enter The File Name: ");
                string fileNameList = Console.ReadLine();
                while (writing == true)
                {
                    string onestring = Console.ReadLine();
                    Console.WriteLine(line + colin + onestring);
                    if (onestring == "exit" || onestring == "Exit")
                    {
                        writing = false;
                        Console.WriteLine("saved: " + fileNameList + "\n<Press Any Key To Go To Menu>");
                        Console.ReadLine();
                        mainMenu();
                    }else{
                      File.AppendAllText(@fileNameList + ".txt", line + colin + onestring + Environment.NewLine);
                      line = line + 1;
                    }

                }
            }
            private static void login()
            {
                StreamReader readUserName = new StreamReader(@"WhichOS_Username.txt");
                string storedUsername = readUserName.ReadToEnd();
                string storedUsernameUsable = storedUsername;
                StreamReader readUserPassword = new StreamReader(@"WhichOS_Password.txt");
                string storedPassword = readUserPassword.ReadToEnd();
                string storedPaswordUsable = storedPassword;
                Console.Clear();
                //Login!
                Console.WriteLine("LOGIN");
                Console.WriteLine("-----------------------");
                Console.Write("Please Enter Your username: ");
                string userNameInputLogin = Console.ReadLine();
                Console.Write("Please Enter Password: ");
                string userPasswordInputLogin = Console.ReadLine();
                if (userNameInputLogin == storedUsernameUsable && userPasswordInputLogin == storedPaswordUsable)
                {
                    Console.WriteLine("You logged in.");
                    mainMenu();
                }
                //If the Username/Password is incorrect...this will show up.
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.WriteLine("Your Username And/Or Password Was Incorrect!\n<Press Any Key To Go Back>");
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    login();

                }
            }
            private static void textEditor()
            {

                //the begginning of a journey -Parasol 2018






















            }
            private static void cratorOSCommandLine()
            {
                Console.WriteLine("Welcome To Crator OS Command Line Tool Copyright MojangIsTraash 2k18");
                Console.Write("Please Entern A Command: ");
                string cratorOSCommandInput = Console.ReadLine();

            }
            //Number Game Method
            private static void numberGame()
            {
                Console.Clear();
                Console.WriteLine("Welcome To The Number Game!\nThe Objective Is To Guess The Number Between 1 And 10");
                Console.WriteLine("Answer The QUestion Correctly To Win!");
                Random randomDigit1 = new Random();
                int randomNumber = randomDigit1.Next(1, 11);
                Console.Write("Please Enter A Digit Between 1 And 10: ");
                //User Input for the number they Choose
                string userAnswerInput = Console.ReadLine();
                int userAnswerInputInt = int.Parse(userAnswerInput);
                //Result of being right!
                if (userAnswerInputInt == randomNumber)
                {
                    Console.Write("You Win! Play Again?(y/n): ");
                    string playAgainWin = Console.ReadLine();
                    if (playAgainWin == "y" || playAgainWin == "Y")
                    {
                        Console.Clear();
                        numberGame();
                    }

                    else if (playAgainWin == "n" || playAgainWin == "N")
                    {
                        Console.Clear();
                        mainMenu();
                    }
                }
                //Result of Being Wrong...
                else if (userAnswerInputInt != randomNumber)
                {
                    Console.Write("You Lose... Try Again?(Y/N): ");
                    string playAgainLose = Console.ReadLine();
                    if (playAgainLose == "y" || playAgainLose == "Y")
                    {
                        Console.Clear();
                        numberGame();
                    }
                    else if (playAgainLose == "n" || playAgainLose == "N")
                    {
                        Console.Clear();
                        mainMenu();
                    }
                }

                //Text editor method!


                Console.ReadLine();
            }

            //Static method called in the begging of the script
            public static void Main(string[] args)
            {

                //Background Color and ForegroundColor set
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                try
                {
                    //Checking if the user has made an account before by checking the txt files
                    if (File.Exists(@"C:\Users\Public\WhichOS_Username.txt") && File.Exists(@"C:\Users\Public\WhichOS_Password.txt") || File.Exists(@"WhichOS_Username.txt") && File.Exists(@"WhichOS_Password.txt"))
                    {
                        login();
                    }
                }
                //If the file given could not have been read
                catch (Exception e)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("The file could not be read");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }



                //  Create Account Screen
                if (File.Exists(@"C:\Users\Public\WhichOS_Username.txt") == false && File.Exists(@"C:\Users\Public\WhichOS_Password.txt") == false || File.Exists(@"/home/WhichOS_Username.txt") == false && File.Exists(@"\home\WhichOS_Password.txt") == false)
                {
                    Random randMotoNumberPicker = new Random();
                    int randMoto =  randMotoNumberPicker.Next(1, 9);
                    string randMotoOutput = "";
                    if (randMoto == 1)
                    {
                        randMotoOutput = "Watch For Astroids!";
                    }
                    else if (randMoto == 2)
                    {
                        randMotoOutput = "Wait For Impact!";
                    }
                    else if (randMoto == 3)
                    {
                        randMotoOutput = "Oh No, Its Coming Down!";
                    }
                    else if (randMoto == 4)
                    {
                        randMotoOutput = "ITS A BIRD, ITS A PLANE, ITS...An OS?";
                    }
                    else if (randMoto == 5)
                    {
                        randMotoOutput = "Who Knew An OS Could Be So Powerful...";
                    }
                    else if (randMoto == 6)
                    {
                        randMotoOutput = "Wow! Whats That In The Sky...";
                    }
                    else if (randMoto == 7)
                    {
                        randMotoOutput = "Hey, I Didn't See That Crator Yesterday!";
                    }
                    else if (randMoto == 8)
                    {
                        randMotoOutput = "Is It A Meteor, Or An Astroid? Okay, Im Confused.";
                    }

                    Console.WriteLine("Welcome To CratorOS, " + randMotoOutput);
                    Console.WriteLine("    CREATE ACCOUNT");
                    Console.WriteLine("------------------------");
                    Console.Write("Please Enter Your username: ");
                    string userNameInputCreate = Console.ReadLine();
                    Console.Write("Please Enter Password: ");
                    string userPasswordInputCreate = Console.ReadLine();
                    System.IO.File.WriteAllText(@"WhichOS_Username.txt", userNameInputCreate);
                    System.IO.File.WriteAllText(@"WhichOS_Password.txt", userPasswordInputCreate);
                    Console.WriteLine("Press Any Key...");

                    Console.ReadLine();
                    Console.Clear();
                    mainMenu();
                    Console.ReadLine();

                }
            }
        }
    }
}
