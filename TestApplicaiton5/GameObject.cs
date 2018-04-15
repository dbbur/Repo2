/*
 * Doesn't need to be in this class if it makes sense to be elsewhere, just creating a placeholder class.
 * 
 * -Display and confirm if the answer was correct to the user
-Display total score after selected game length is completed.
-Randomly generate questions

 * 
 * TODO: (GetInquiryList) Need to create more Inquiry variables for the array.
 *          (GetInquiryList) Need to only return number of variables in list as are specified in the parameter.
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
        /*Takes a int parameter for the number of questions and returns that number of questions in a array List<Inquiry>.  */
        public List<Inquiry> GetInquiryList(int inqRequested)
        {
            //Initilizes a list of Inquiry variables while building the array
            List<Inquiry> inquiryList = new List<Inquiry>()
            {
                new Inquiry {Question = "Which actor stars in the movie Beetleguise?", Answer = "Michael Keaton", MultiChoice1 = "Michael Keaton", MultiChoice2= "Danny DeVito", MultiChoice3 = "David Cross" }
            };

            return inquiryList;
        } 


    }
}
