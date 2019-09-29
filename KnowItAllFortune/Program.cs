using System;

namespace MrKnowItAll
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(" \n Welcome To Mr. Know It All!\n The Fortune Telling App\n Discover Your Future By Answering These Questions...\n");


            //Ask user For First And Last Name

            Console.Write(" To Begin Please Tell Me Your First Name : ");
            string firstName = Console.ReadLine();
            string firstNameLower = firstName.ToLower();

            Console.Write(" What Is Your Last Name? : ");
            string lastName = Console.ReadLine();
            string lastNameLower = lastName.ToLower();

            Console.WriteLine(" \n Hello " + firstName + " " + lastName + " It Is Nice to Meet You! ");



            //Ask User For Age

            Console.WriteLine(" \n Before We Continue I Will Need To Ask You A Few More Questions\n ");

            Console.Write(" What Is Your Age In Years?  ");
            string ageResponse = Console.ReadLine();
            int newAge = Convert.ToInt16(ageResponse);




            //Ask The User For Birth Month

            int usersBirthMonth = 0;

            while (usersBirthMonth < 1 || usersBirthMonth > 12)
            {
                Console.Write(" Enter Your Birth Month As A Number Jan = 1, Feb = 2, Mar = 3: ");
                string userResponse = Console.ReadLine();
                usersBirthMonth = Convert.ToInt16(userResponse);
            }



            //Ask The User For Sibllings

            Console.Write(" How Many Siblings Do You Have?   ");
            string family = Console.ReadLine();
            int newFamily = Convert.ToInt16(family);




            //Ask User For Favorite Color ROYGBIV Display Help Message

            Console.Write(" \n What Is Your Favorite ROYGBIV Color? \n ");
            Console.Write(" \n Do You Wnat To See A List of Colors? Enter Yes Or No: ");


            string answerToHelp = Console.ReadLine();
            string answerToHelpLower = answerToHelp.ToLower();


            if (answerToHelpLower == "yes")
            {
                Console.WriteLine(" The ROYGBIV Colors Are: \n" +
                " Red \n Orange \n Yellow \n Green \n Blue \n Indigo \n Violet \n ");

            }


            Console.Write(" \n What Is Your Favorite ROYGBIV Color? \n ");
            string answerToColor = Console.ReadLine();
            string answerToColorLower = answerToColor.ToLower();

            if (answerToColorLower == "red")
            {
                Console.Write(" \n Here Is Your YOUR FUTURE... " + firstName + " " + lastName + "!" + " \n Your Mode Of Transportation Will Be A Maserati ");
            }

            else if (answerToColorLower == "orange")
            {
                Console.Write(" \n Here Is Your YOUR FUTURE... " + firstName + " " + lastName + "!" + " \n Your Mode Of Transportation Will Be A Camel ");
            }

            else if (answerToColorLower == "yellow")
            {
                Console.Write(" \n Here Is Your YOUR FUTURE... " + firstName + " " + lastName + "!" + " \n Your Mode Of Transportation Will Be A Cruise Ship ");
            }

            else if (answerToColorLower == "green")
            {
                Console.Write(" \n Here Is Your YOUR FUTURE... " + firstName + " " + lastName + "!" + " \n Your Mode Of Transportation Will Be A Scooter");
            }

            else if (answerToColorLower == "blue")
            {
                Console.Write(" \n Here Is Your YOUR FUTURE... " + firstName + " " + lastName + "!" + " \n Your Mode Of Transportation Will Be A Plane");
            }

            else if (answerToColorLower == "indigo")
            {
                Console.Write(" \n Here Is Your YOUR FUTURE... " + firstName + " " + lastName + "!" + " \n Your Mode Of Transportation Will Be A Bike");
            }

            else if (answerToColorLower == "violet")
            {
                Console.Write(" \n Here Is Your YOUR FUTURE... " + firstName + " " + lastName + "!" + " \n Your Mode Of Transportation Will Be A Flying Saucer ");
            }




            //Retirement Years Based On Odd Or Even

            if (newAge % 2 == 0)
            {
                Console.WriteLine("\n You Will Retire In " + "15 Years And ");
            }

            else
            {
                Console.WriteLine("\n You Will Retire In " + "25 Years And");
            }




            //The User's Bank Balance At Retirement Will Be Based On The User's Birth Month.

            if (usersBirthMonth >= 4)
            {
                Console.WriteLine(" Your Bank Balance Will Be $1,300,000 ");
            }

            else if (usersBirthMonth <= 5)
            {
                Console.WriteLine(" Your Bank Balance Will Be $3,687,105.42 ");
            }

            else if (usersBirthMonth <= 9)
            {
                Console.WriteLine(" Your Bank Balance Will Be $10,697,203.99 ");
            }

            else
            {
                Console.WriteLine(" Your Bank Balance Will Be $10 ");
            }




            //User's Vacation Home Will Be Based On How Many Siblings The User Has

            if (newFamily == 0)
            {
                Console.WriteLine(" Your Vacation Home Will Be In WestLake Ohio. Good Luck! \n ");
            }

            else if (newFamily == 1)
            {
                Console.WriteLine(" Your Vacation Home Will Be In WestLake Ohio. Good Luck! \n ");
            }

            else if (newFamily == 2)
            {
                Console.WriteLine(" Your Vacation Home Will Be In Lorain Ohio. Good Luck! \n ");
            }

            else if (newFamily <= 3)
            {
                Console.WriteLine(" Your Vacation Home Will Be In Mentor Ohio. Good Luck! \n ");
            }

            else if (newFamily == 4)
            {
                Console.WriteLine(" Your Vacation Home Will Be In Fairview Park Ohio . Good Luck1 \n ");
            }

            else
            {
                Console.WriteLine(" Your Vacation Home Will Be In Elyria Ohio. Good Luck! \n ");
            }



            //Print Future:
            //[First Name] [Last Name] [mode of transportation] will retire in [# of years] 
            //with [bank balance] in the bank,
            //a vacation home in [location]

        }
    }
}
