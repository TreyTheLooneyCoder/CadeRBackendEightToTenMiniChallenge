using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRBackendEightToTen.Services
{
    public class Magic8BallServices
    {
        public string ShakeIt(string question)
        {
            if(question == "")
            {
                return "You have to input something...";
            }
            else
            {
                string[] responses = {"The Answer is yes", "The Response is No", "NEVER!!!", "Are you Mocking My Inteligence human", "Seriously?", "YES YES ONE THOUSAND TIMES YES!!", "No Bro I Mean Come On Now", "the answer to your moronic question is no"};

                Random rng = new Random();

                int turnResponsesRandom = rng.Next(responses.Length);

                string randomResponses = responses[turnResponsesRandom];
                
                return randomResponses;
            }
        }
    }
}