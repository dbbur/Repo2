﻿/*
 * 
 * -Store and retrieve question list by category
    - Inquiry Class
        - Question
        - Anwer - Mult1
        - Mult Choice 1
        - Mult Choice 2
        - Mult Choice 3
 * 
 * 
 * 
 * */






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicaiton5
{
    class Inquiry
    {
        //List of properties
        public string KeyId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Category { get; set; }
        public string MultiChoice1 { get; set; }
        public string MultiChoice2 { get; set; }
        public string MultiChoice3 { get; set; }

        //Constructor method with no input parameters
        public Inquiry ()
        {

        }

        //Constructor method with input parameters
        public Inquiry (string keyid, string question, string answer, string category, string multiChoice1, string multiChoice2, string multiChoice3)
        {
            this.KeyId = keyid;
            this.Question = question;
            this.Answer = answer;
            this.Category = category;
            this.MultiChoice1 = multiChoice1;
            this.MultiChoice2 = multiChoice2;
            this.MultiChoice3 = multiChoice3;
        }

    }
}
