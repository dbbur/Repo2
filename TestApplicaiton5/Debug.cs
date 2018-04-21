using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicaiton5
{
    class Debug
    {

        //Adding menus to make calls out to a particular classes/methods so those can be tested individually without needing all Classes/methods to run.
        public static void Menu()
        {
            Console.WriteLine("\nDebug menu");
            Console.WriteLine("1. Game Object Class \n2. Display Controller Class \n3. Inquiry Class \n4. Increment Score");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                List<Inquiry> iList = new List<Inquiry>();
                iList = GameObject.GetInquiryList(2, "Movie");
            }
            else if (userInput == "2")
            {
                //Can insert method call to Display Controller
            }
            else if (userInput == "3")
            {
                //Can insert method call to Inquiry Class
            }
            else if (userInput == "4")
            {
                GameObject go = new GameObject();
                Console.WriteLine(go.playerScore);
                go.IncrementPlayerScore();
                Console.WriteLine(go.playerScore);
            }
            Console.Read();

        }
    
    }
}
