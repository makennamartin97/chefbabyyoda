using System;
namespace chefbabyyoda.Models
{
    public class Menu
    {
        string [] Food = new string []
        {
            "Ewok",
            "Cookie",
            "Cannoli",
            "Squash",
            "Cupcake",
            "Enchiladas",
            "Donut",
            "Cheeze-it"
        };
        string [] Preparations = new string []
        {
            "Frosted",
            "Burnt",
            "Blended",
            "Choco-dipped",
            "Sprinkled",
            "Glazed",
            "Bruleed",
            "Meatballed",
            "Fried"
        };
        string [] Fillings = new string[]
        {
            "jelly",
            "pudding",
            "corn",
            "yogurt",
            "marshmallow",
            "mushroom",
            "chicken"

        };
        public string Value {get; set;}
        public Menu()
        {
            Random rand = new Random();
            Value += Preparations[rand.Next(Preparations.Length)];
            Value += " ";
            Value += Food[rand.Next(Food.Length)];
            Value += " stuffed with ";   
            Value += Fillings[rand.Next(Fillings.Length)];


        }
    }
}