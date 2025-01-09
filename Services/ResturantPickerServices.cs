using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRBackendEightToTen.Services
{
    public class ResturantPickerServices
    {
        public string RandomPick(string foodType)
        {
            string[][] allResturants = 
            {
                ["Tequileros Taqueria", "El Pazcifico Mexican Grill & Cantina", "La Taqueria El Frutal", "El Chilango Chido", "Tepa Taqueria", "Taqueria El Azteca", "La Mesa", "Las Brasas", "Fondita Mexican Resturant", "Tu Pueblito Taqueria"],
                ["China WOK", "Panda Express", "Yen Du", "China Village", "Dave Wong's", "Wild Chinese Buffet", "Mandarin Villa Express", "China Palace", "Wing's Deli & BBQ", "Prosperity Szechuan Cuisine"], 
                ["Pietro's", "Padella Italiana Di Mario", "De Parsia's Resturant & Catering", "Mezzo", "De Vega Brothers", "Angelinas", "Pastosa By Lucia", "L'Gusto Cucina Italiana", "Gian's Delicatessen", "De Vinci's"]
            };                
                
            if(foodType != "Mexican" && foodType != "Chinese" && foodType != "Italian" && foodType != "mexican" && foodType != "chinese" && foodType != "italian")
            {
                return "Please enter something valid or check your spelling :( ";
            }
            else if(foodType == "Mexican" || foodType == "mexican")
            {
                Random rng = new Random();
                int random = rng.Next(10);
                return $"Your resturant is {allResturants[0][random]}";
            }
            else if(foodType == "Chinese" || foodType == "chinese")
            {
                Random rng = new Random();
                int random = rng.Next(10);
                return $"Your resturant is {allResturants[1][random]}";
            }
            else
            {
                Random rng = new Random();
                int random = rng.Next(10);
                return $"Your resturant is {allResturants[2][random]}";
            }  
        }
    }
}