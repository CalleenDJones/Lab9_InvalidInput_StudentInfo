using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int i;

            //Declare ArrayList
            ArrayList studentList = new ArrayList();
            ArrayList hometownlocationList = new ArrayList();
            ArrayList topfoodList = new ArrayList();
            ArrayList favoriteanimalList = new ArrayList();

            //Declare all ArrayList elements for Student, HometownLocation, FavoriteFood and Favorite Animal
            studentList.Add("Peter Parker");
            studentList.Add("Steve Rogers");
            studentList.Add("Luke Cage");
            studentList.Add("Matt Murdock");
            studentList.Add("Jessica Jones");
            studentList.Add("James Bucky Barnes");
            studentList.Add("Bruce Banner");
            studentList.Add("King T'Challa");
            studentList.Add("Peter J. Quill");
            studentList.Add("I Am Groot");
            studentList.Add("Gamora Titan");
            studentList.Add("Thanos Titan");
            studentList.Add("Silver Surfer");
            studentList.Add("Adam Warlock");
            studentList.Add("Drax Destroyer");
            studentList.Add("Okoye J'Kwali");
            studentList.Add("Nakia Q'Noma");
            studentList.Add("Princess Shuri");
            studentList.Add("Wanda Maximoff");
            studentList.Add("Thor Odinson");

            hometownlocationList.Add("Queens, NY");
            hometownlocationList.Add("Brooklyn, NY");
            hometownlocationList.Add("Harlem, NY");
            hometownlocationList.Add("Hell's Kitchen, NY");
            hometownlocationList.Add("Forest Hills, NY");
            hometownlocationList.Add("Brooklyn, NY");
            hometownlocationList.Add("Dayton, OH");
            hometownlocationList.Add("Capital City, Wakanda");
            hometownlocationList.Add("St. Charles, MO");
            hometownlocationList.Add("Planet X");
            hometownlocationList.Add("Planet Titan");
            hometownlocationList.Add("Planet Titan");
            hometownlocationList.Add("Zenn-La, Deneb");
            hometownlocationList.Add("Cosmic Cube, Omniversal");
            hometownlocationList.Add("Burbank, CA");
            hometownlocationList.Add("Capital City, Wakanda");
            hometownlocationList.Add("Capital City, Wakanda");
            hometownlocationList.Add("Capital City, Wakanda");
            hometownlocationList.Add("Mt. Wundagore, Transia");
            hometownlocationList.Add("Asgard, Omniverse");

            topfoodList.Add("Pizza");
            topfoodList.Add("Coney Island");
            topfoodList.Add("Steak, Medium");
            topfoodList.Add("Sushi");
            topfoodList.Add("Beer Nuts");
            topfoodList.Add("Loose Burger");
            topfoodList.Add("Bison Burger");
            topfoodList.Add("Curry Chicken");
            topfoodList.Add("Spaghetti");
            topfoodList.Add("Avacados");
            topfoodList.Add("Chicken Fried Rice");
            topfoodList.Add("Beef BBQ Ribs");
            topfoodList.Add("Egg Rolls");
            topfoodList.Add("Tacos");
            topfoodList.Add("Beef Burritos");
            topfoodList.Add("Chili Con Corne");
            topfoodList.Add("Hoisin Chicken");
            topfoodList.Add("Chicken Tenders");
            topfoodList.Add("Beer Battered Cod with Fries");
            topfoodList.Add("Lemon Pepper Roasted Chicken");

            favoriteanimalList.Add("Spider");
            favoriteanimalList.Add("Eagle");
            favoriteanimalList.Add("Lion");
            favoriteanimalList.Add("Tazmanian Devil");
            favoriteanimalList.Add("Cheetah");
            favoriteanimalList.Add("Hawk");
            favoriteanimalList.Add("Bear");
            favoriteanimalList.Add("Black Panter");
            favoriteanimalList.Add("Quill");
            favoriteanimalList.Add("Giraffe");
            favoriteanimalList.Add("Frog");
            favoriteanimalList.Add("Hippopotamus");
            favoriteanimalList.Add("Silver-Back Bear");
            favoriteanimalList.Add("Gorilla");
            favoriteanimalList.Add("Elephant");
            favoriteanimalList.Add("Tiger");
            favoriteanimalList.Add("Leopard");
            favoriteanimalList.Add("Chimpanzee");
            favoriteanimalList.Add("Viper");
            favoriteanimalList.Add("Electric Eel");


            //Introduce user
            Console.WriteLine("Welcome to our C# Meridian Bootcamp Class.");
            bool success = true;
            while (success)
            {
                //Ask user to select student
                Console.WriteLine("Which student would you like to learn more about?");
                Console.WriteLine("Please enter a number from 1-20: ");
                //Returns users student selection designated as StudentID
                string StudentID = Console.ReadLine();

                //Call ValidStudent Method, should return an int value
                int Choosen = ValidStudent(StudentID);


                //take returned int value and locate that student
                //we subtract 1 to line up with our array
                Console.WriteLine($"Student {StudentID} is {studentList[Choosen - 1]}.");



                Console.WriteLine($"\n\nWould you like to know about {studentList[Choosen - 1]}'s Hometown, Favorite Food");
                Console.WriteLine($"or Spirit Animal?");
                Console.WriteLine($"Type either 'hometown', 'favorite food' or 'spirit animal':");
                string KnowMore = Console.ReadLine().ToLower();


                {
                    while (success)
                        if (KnowMore != "hometown" && KnowMore != "favorite food" && KnowMore != "spirit animal")
                        {
                            Console.WriteLine($"\nSorry, that's an invalid response");
                            Console.WriteLine($"Select either 'hometown', 'favorite food' or 'spirit animal':");
                            KnowMore = Console.ReadLine().ToLower();
                        }
                        else if (KnowMore == "hometown")
                        {
                            Console.WriteLine($"\n\n{studentList[Choosen - 1]} is from {hometownlocationList[Choosen - 1]}.");
                            success = false;
                        }

                        else if (KnowMore == "favorite food")
                        {
                            Console.WriteLine($"\n{studentList[Choosen - 1]}'s Favorite Food is: {topfoodList[Choosen - 1]}.");
                            success = false;
                        }
                        else if (KnowMore == "spirit animal")
                        {
                            Console.WriteLine($"\n\n{studentList[Choosen - 1]}'s Spirit Animal is a/an: {favoriteanimalList[Choosen - 1]}.");
                            success = false;
                        }
                }
                //success = true;
                

                Console.WriteLine($"\n\nIf you would like to know more about an existing student, type 'y' or 'n'.");
                Console.WriteLine($"OR");
                Console.WriteLine($"If you would like to ADD a new student, type 'add'.");
                string GoOn = Console.ReadLine().ToLower();
                if (GoOn == "n")
                {
                    success = false;
                }
                else if (GoOn == "add")
                {
                    Console.WriteLine("Please enter new student's First and Last name:");
                    string addedName = Console.ReadLine();
                    int Valid1;
                    bool ValidName1 = int.TryParse(addedName, out Valid1);
                    if (ValidName1 == true)
                    {
                        Console.WriteLine("That was not a valid name, try again");
                    }
                    else if (ValidName1 == false)
                    {
                        studentList.Add(addedName);
                        success = true;
                    }

                    Console.WriteLine("Please enter new student's Hometown (city, State's Abbreviation): ");
                    string addedHometown = Console.ReadLine();
                    int Valid2;
                    bool ValidHometown1 = int.TryParse(addedHometown, out Valid2);
                    if (ValidHometown1 == true)
                    {
                        Console.WriteLine("That was not a valid entry for a hometown, try again");
                    }
                    else if (ValidHometown1 == false)
                    {
                        hometownlocationList.Add(addedHometown);
                        success = true;
                    }

                    Console.WriteLine("Please enter new student's Favorite Food: ");
                    string addedTopFood = Console.ReadLine();
                    int Valid3;
                    bool ValidTopFood1 = int.TryParse(addedTopFood, out Valid3);
                    if (ValidTopFood1 == true)
                    {
                        Console.WriteLine("That was not a valid entry for a Favorite Food, try again");
                    }
                    else if (ValidTopFood1 == false)
                    {
                        topfoodList.Add(addedTopFood);
                        success = true;
                    }

                    Console.WriteLine("Please enter new student's Spirit Animal: ");
                    string addedTopAnimal = Console.ReadLine();
                    int Valid4;
                    bool ValidTopAnimal1 = int.TryParse(addedTopAnimal, out Valid4);
                    if (ValidTopAnimal1 == true)
                    {
                        Console.WriteLine("That was not a valid entry for a Spirit Animal, try again");
                    }
                    else if (ValidTopAnimal1 == false)
                    {
                        favoriteanimalList.Add(addedTopAnimal);
                        success = false;
                    }
                    
                       
                        //Console.WriteLine("Would you like to continue learning about more students ");
                        //Console.WriteLine("or exit the program? Type 'y' to continue or 'n' to exit the program.");
                        //string FinalChoice = Console.ReadLine().ToLower();

                        //if (FinalChoice == "n")
                        //{
                        //    return;
                        //}




                        Console.WriteLine("Would you like to continue learning about more students ");
                        Console.WriteLine("or get totals? Type 'y' to continue or 'n' to get totals.");
                        string FinalChoice = Console.ReadLine().ToLower();

                        if (FinalChoice == "n")
                        {
                            //return;
                            for (i = 0; i < studentList.Count; i++)
                            {
                                studentList.Sort();
                                Console.WriteLine(studentList[i]);
                            }
                        }
                    
                }
            }
            
            Console.WriteLine("Please press enter to exit...");
            Console.ReadKey();
        }

        public static int ValidStudent(string Input)
        {
            int Num1;
            while (true)
            {
                //try to make string input a valid number
                if (!int.TryParse(Input, out Num1))
                {
                    Console.WriteLine("Sorry, that student does not exist.");
                    Console.WriteLine("Please try again. (enter a number 1-20):");
                    Input = Console.ReadLine();
                }
                //see if valid number is in a certain range
                else if (Num1 < 1 || Num1 > 20)
                {
                    Console.WriteLine("Sorry, that student does not exist.");
                    Console.WriteLine("Please try again. (enter a number 1-20):");
                    Input = Console.ReadLine();
                }
                else
                {
                    return Num1;
                }
            }
        }
    }
}

