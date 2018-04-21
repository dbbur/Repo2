/*
 * Doesn't need to be in this class if it makes sense to be elsewhere, just creating a placeholder class.
 * 
 * -(done)Display and confirm if the answer was correct to the user
- (done) Displays total score after selected game length is completed.
- (done)Randomly generate questions/inquiry objects

 * 
 * TODO: (GetInquiryList) Need to create more Inquiry variables for the array.
 * Need to change IncrementPlayerScore back to private, public for debuging class call.
 *       
 *          
 * 
 */









using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicaiton5
{
    class GameObject
    {
        //private static int playerscore = 0; //Initializes player score local varable for use in the property.
        public int playerScore { get; set; } //Initializes player score property.
        

        /*Takes a int parameter for the number of questions and string for the category then returns that number of questions for that category in an List<Inquiry>.  */
        public static List<Inquiry> GetInquiryList(int inqCount, string inqCategory)
        {
            Random rng = new Random();
            //Creates a list variable to recieve in the List of Inquiry that will be returned back from the InitializeInquiryList method call.  Method is static so an instance of the class isn't needed.
            List<Inquiry> inquiryList = InitializeInquiryList();


            //Leveraging the Linq query syntax to only pull certain Inquiry records out of the List
            var varSpecifiedInquires = from Inquiry in inquiryList
                                       where Inquiry.Category == inqCategory
                                       select Inquiry;


            return varSpecifiedInquires.Take(inqCount).OrderBy(a => rng.Next()).ToList();  //Takes only a certain number of items from the List, then orders it by a random count, and then casts the var back into a List of Inquiry type
            
        }


        /*Recieves the Inquiry KeyId (string) and the answer (string) provided by the user then returns a boolean if it's the correct answer*/
        public bool ConfirmInquiryAnswer(string inqKey, string userAnswer)
        {
            List<Inquiry> inquiryList = InitializeInquiryList();
            List<Inquiry> iList = (from Inquiry in inquiryList
                                       where Inquiry.KeyId == inqKey
                                       select Inquiry).ToList();


            //Compares the user Answer with the Inquiry to confirm if it matches
            if (iList.Count != 0)
            {
                if (userAnswer == "1")
                {
                    if (iList[0].MultiChoice1 == iList[0].Answer)
                    {
                        IncrementPlayerScore();
                        return true;
                    }
                }
                else if (userAnswer == "2")
                {
                    if (iList[0].MultiChoice2 == iList[0].Answer)
                    {
                        IncrementPlayerScore();
                        return true;
                    }
                }
                else if (userAnswer == "3")
                {
                    if (iList[0].MultiChoice3 == iList[0].Answer)
                    {
                        IncrementPlayerScore();
                        return true;
                    }
                }
                else
                    return false;
            }
            else
                return false;

            return false; //if for some reason we get to this point without already returning a result...
        }


        /*Increments the player's score. */
        public void IncrementPlayerScore()
        {
            playerScore++;
        }


        /*Initilizes a list of Inquiry variables and returns it as a List array  */
        private static List<Inquiry> InitializeInquiryList()
        {
            //Populates the List and then returns it.
            return new List<Inquiry>()
            {
                new Inquiry {KeyId = "1", Question = "Which actor stars in the movie Beetleguise?", Answer = "Michael Keaton", Category = "Movie", MultiChoice1 = "Michael Keaton", MultiChoice2 = "Danny DeVito", MultiChoice3 = "David Cross" },
                new Inquiry {KeyId = "2", Question = "What year was the Matrix released?", Answer = "1999", Category = "Movie", MultiChoice1 = "1999", MultiChoice2 = "1995", MultiChoice3 = "1997" },
                new Inquiry {KeyId = "3", Question = "Which games series is owned by Nintendo?", Answer = "Zelda", Category = "Game", MultiChoice1 = "Zelda", MultiChoice2 = "Final Fantasy", MultiChoice3 = "Bioshock" },
                new Inquiry {KeyId = "4", Question = "What is the largest city in Oregon?", Answer = "Portland", Category = "Other", MultiChoice1 = "Portland", MultiChoice2 = "Salem", MultiChoice3 = "Eugene" }
            };


        }



    }
}
