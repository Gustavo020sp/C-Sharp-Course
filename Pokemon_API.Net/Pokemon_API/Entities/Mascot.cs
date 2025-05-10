using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Pokemon_API.Entities
{
    public class Mascot
    {
        public string? name { get; set; }
        public int height { get; set; }
        public int weight { get; set; }

        public int Humor { get; set; }
        public int Hunger { get; set; }

        public List<AbilityWrapper>? abilities { get; set; }

        //public Mascot(int humor, int hunger)
        //{
        //    Humor = humor;
        //    Hunger = hunger;
        //}

        public void PLayMascot()
        {
            Humor++;
            Hunger--;
            Console.WriteLine(Environment.NewLine + "YOU ARE PLAYING WITH YOUR MASCOT.... YYEEAHHUU !" + Environment.NewLine
                + "Humor = " + Humor + Environment.NewLine
                    + "Hunger = " + Hunger + Environment.NewLine);
        }

        public void FeedMascot()
        {
            Humor++;
            Hunger++;
            Console.WriteLine(Environment.NewLine + "YOUR MASCOT IS BEEING FEEDED.... YUMMY !" + Environment.NewLine
                + "Humor = " + Humor + Environment.NewLine
                    + "Hunger = " + Hunger + Environment.NewLine);
        }

        public void StatusMascot()
        {
            string status = "";

            if (Humor >= 5 && Hunger >= 5)
            {
                status = Environment.NewLine + "YOUR MASCOT STATUS: :) :) :) Your Mascot is HAPPY and FEEDED!! :) :) :)" + Environment.NewLine
                    + "Humor = " + Humor + Environment.NewLine 
                    + "Hunger = " + Hunger;

            }

            if (Humor < 5 && Hunger < 5)
            {
                status = Environment.NewLine + "YOUR MASCOT STATUS: :( :( :( Your Mascot is SAD and HUNGRY!! :( :( :( " + Environment.NewLine
                    + "Humor = " + Humor + Environment.NewLine
                    + "Hunger = " + Hunger;

            }

            if (Humor >= 5 && Hunger < 5)
            {
                status = Environment.NewLine + "YOUR MASCOT STATUS: :/ :/ :/ Your Mascot is HAPPY but HUNGRY!! :/ :/ :/" + Environment.NewLine
                    + "Humor = " + Humor + Environment.NewLine
                    + "Hunger = " + Hunger;
            }

            if (Humor <= 5 && Hunger > 5)
            {
                status = Environment.NewLine + "YOUR MASCOT STATUS: :/ :/ :/ Your Mascot is FEEDED but SAD!! :/ :/ :/" + Environment.NewLine
                    + "Humor = " + Humor + Environment.NewLine
                    + "Hunger = " + Hunger;
            }
            Console.WriteLine(Environment.NewLine + status + Environment.NewLine);
        }

        public override string ToString()
        {
            string abilityname = "";

            foreach (var abilityWrapper in abilities)
            {
                abilityname += "- " + abilityWrapper.Ability.name + Environment.NewLine;
            }

            return Environment.NewLine + "-------POKEMON INFORMATIONS-----------" + Environment.NewLine + "Pokemon Name: " + name + Environment.NewLine
                + "Height: " + height + Environment.NewLine
                + "Weight: " + weight + Environment.NewLine
                + "Abilities: " + Environment.NewLine
                + abilityname + "-------------------------------------";
        }

    }
}
