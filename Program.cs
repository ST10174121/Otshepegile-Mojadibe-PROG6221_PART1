using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ESSENTIAL_COOKBOOK
{

    internal class Program
    {
        //Dclaring Variables
        public static string Name { get; private set; }
        public ArrayList NumberOfIngredients { get; private set; }
        public static int Quantity { get; private set; }
        public static string UnitOfMeasurement { get; private set; }
        public ArrayList StepDescription { get; private set; }


        static void Main(string[] args)
        {
            //Declaring Switch statement 
            int choice;

            do
            {
                //Menu Display
                Console.WriteLine("Welcome To Your Essential CookBook!");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("                                      ");
                Console.WriteLine("What Would You like to try today?");
                Console.WriteLine("                                      ");
                Console.WriteLine("1. Display Recipe ChoiceList to Make!");
                Console.WriteLine("2. Create a Recipe! ");
                Console.WriteLine("3. Scale Ingredients! ");
                Console.WriteLine("4. Display All Recipes Created!");
                Console.WriteLine("5. ClearRecipes!");
                Console.WriteLine("6. Exit COOKPAD!!");
                Console.WriteLine("                                      ");
                Console.WriteLine(" Select A Choice From 1-6");
                choice = Convert.ToInt32(Console.ReadLine());

                //Switch statement so that the user can select an option
                switch (choice)
                {
                    case 1:// A List of recipes the user can select from
                        Console.WriteLine("Here's a list of Recipes to choose from!-->");
                        Console.WriteLine("Braai Meat " +
                        "\r\n" +
                        " 1. Chicken\r\n" +
                        " 2. Beef\r\n" +
                        " 3. Leg Of Lamb \r\n" +
                        " 4. Roasted Mielies\r\n" +
                        "\r\n" +
                        "Cooking" +
                        "\r\n" +
                        " 5. Pap\r\n" +
                        " 6. Flavourful Chakalaka Sauce\r\n" +
                        "\r\n" +
                        "Salads" +
                        "\r\n" +
                        " 7. Roasted Vegetables\r\n" +
                        " 8. Sweet Potatoes\r\n" +
                        "\r\n" +
                        "9. Freshly Oven Baked Bread\r\n" +
                        "\r\n" +
                        "Desserts" +
                        "\r\n" +
                        "10. Mulva Pudding\r\n" +
                        "11. Custard\r\n" +
                        "12. Chocolate Pudding\r\n" +
                        "13. Chocolate Ice Cream\r\n");

                        Console.WriteLine("Press Enter To Display The ChoiceList!!");//To Display back the menu

                        Console.ReadLine();

                        break;
                    case 2:
                        CreateRecipe();//Fetched Method
                        break;
                    case 3:
                        ScaleRecipe(Quantity);//Fetch method
                        break;
                    case 4:
                        DisplayRecipe();//Fetch method
                        break;
                    case 5:
                        ClearRecipes();//Fetch Method
                        break;
                    case 6:
                    default:
                        //Exit Application
                        break;
                }


            } while (choice != 4);//To run the menu until the user chooses to exit the Application

        }
        public static void ScaleRecipe(double Quantity)
        {
            Console.WriteLine("Please Enter the Number of The Quantity you want to Scale!!");
            //prompting the user to re enter the value that needs to be scale by a double
            Quantity = int.Parse(Console.ReadLine());//user input
            Quantity = Convert.ToInt32(Quantity);
            Console.WriteLine("The Doubled Quantity Of The Recipe is : " + Quantity);

        }

        public static void CreateRecipe()
        {
            //Declaring Arrays
            String[] NumberOfIngredients = new string[5];
            String[] StepDescription = new string[5];

        

            //Creating the Recipe
            Console.WriteLine("Please Enter the Name of the Recipe You Would Like To Try :");
            Name = Console.ReadLine();//user input

            Console.WriteLine("Please Enter the number of ingredients you would like to use for the recipe and State The Ingredients :");

            //For the user to enter atleast 5 ingredients in an array form
            for (int i = 0; i < 5; i++)
            {
               
                NumberOfIngredients[i] = (Console.ReadLine());
            }

            Console.WriteLine("Now We Going To Enter The Description Details Of The Recipe-->");

            Console.WriteLine("Please Enter the Quantity Of The Recipe? :");
            Quantity = int.Parse(Console.ReadLine());//user input

            Console.WriteLine("Please Enter the Unit Of Measurement of the Recipe(\"for example two tablespoons)\" :");
            UnitOfMeasurement = Console.ReadLine();//user input


            Console.WriteLine("Please State The Number Of Steps You Will Be Using and Describe The Steps :");
            //For the user to enter atleast 5 Steps in an array form
            for (int i = 0; i < 5; i++)
            {
                
                StepDescription[i] = Console.ReadLine();
            }

            Console.WriteLine("Your Recipe Has Been Captured Successfully!!");

            Console.WriteLine("Press Enter To Display The ChoiceList!!");// To display back to the menu choice List

            Console.ReadLine();


        }

        public static void DisplayRecipe()
        {
            //Declared array list variables
            String[] NumberOfIngredients = new string[5];
            String[] StepDescription = new string[5];

            //Displaying the created Recipe
            Console.WriteLine("Here Are The Results Of Your Created Recipe!!");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Today We Are Making : " + Name);
            //Application will Show the entered ingredients in an array list
            for (int i = 0; i < NumberOfIngredients.Length; i++)
            {
                Console.WriteLine("Ingredient [{0}] = {1}", i, NumberOfIngredients[i]);

            }

            Console.WriteLine("The Quantity Of The Recipe : " + Quantity);

            Console.WriteLine("The UnitOfMeasurement is : " + UnitOfMeasurement);


            

            Console.WriteLine("Cooking Instructions :" + StepDescription);
            //Application will Show the entered ingredients in an array list
            for (int i = 0; i < StepDescription.Length; i++)
            {
                Console.WriteLine("Ingredient [{0}] = {1}", i, StepDescription[i]);

            }

            Console.WriteLine("Press Enter To Display The ChoiceList!!");



        }
        public static void ClearRecipes()
        {
            //Will ask the user if you want to clear the recipe 
            char confirm;
            String answer;
            Console.WriteLine("Are You Sure You Want To Clear Your Created Recipe?(1=Yes/2=No)?");
            answer = Console.ReadLine();
            confirm = char.Parse(answer);
            //The selected choice will automatically clear the recipe
            if (confirm == '1')
            {
                Console.WriteLine("Your Recipe Has Been Successfully Cleared");
            }
            if (confirm == '2')
                Console.WriteLine("Press Enter To Display The ChoiceList!!");
        }


    }

}