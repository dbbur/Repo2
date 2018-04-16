/*
 * Doesn't need to be in this class if it makes sense to be elsewhere, just creating a placeholder class.
 * 
 * -Display and confirm if the answer was correct to the user
-Display total score after selected game length is completed.
-Randomly generate questions

 * 
 * TODO: (GetInquiryList) Need to create more Inquiry variables for the array.
 *          (GetInquiryList) Need to only return number of variables in list as are specified in the parameter.
 *          (GetInquiryList) Need add restrict list of of Inquiries based on Category
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
        /*Takes a int parameter for the number of questions and string for the category then returns that number of questions for that category in an List<Inquiry>.  */
        public static List<Inquiry> GetInquiryList(int inqCount, string inqCategory)
        {
            //Initilizes a list of Inquiry variables while building the array
            List<Inquiry> inquiryList = new List<Inquiry>()
            {
                new Inquiry {Question = "Which actor stars in the movie Beetleguise?", Answer = "Michael Keaton", Category = "Movie", MultiChoice1 = "Michael Keaton", MultiChoice2 = "Danny DeVito", MultiChoice3 = "David Cross" },
                new Inquiry {Question = "What year was the Matrix released?", Answer = "1999", Category = "Movie", MultiChoice1 = "1999", MultiChoice2 = "1995", MultiChoice3 = "1997" }
            };


            var varSpecifiedInquires = from Inquiry in inquiryList
                                       where Inquiry.Category == "Movie"
                                       select Inquiry;

            //Console.WriteLine(varSpecifiedInquires.ToList());
            //Console.Write(inquiryList);

            /*
            foreach (Inquiry i in inquiryList)
                Console.WriteLine(i.Question);
           
            Console.Read();
            */

            return inquiryList;
        } 


    }
}
