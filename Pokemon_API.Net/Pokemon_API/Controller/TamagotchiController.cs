using Pokemon_API.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace Pokemon_API.Controller
{
    public class TamagotchiController
    {
        bool hasMascot = false;
        string name = "";
        string pokemonName = "";
        Mascot mascot = new Mascot();

        private const string WelcomeMessage = @"
#######
   #     ##     #    #    ##      ####      ####    #####   ####    #    #  #
   #    #  #    ##  ##   #  #    #     #   #    #     #    #    #   #    #  #
   #   #    #   # ## #  #    #   #         #    #     #    #        ######  #
   #   ######   #    #  ######   #   ###   #    #     #    #        #    #  #
   #   #    #   #    #  #    #   #     #   #    #     #    #    #   #    #  #
   #   #    #   #    #  #    #    ####      ####      #     ####    #    #  #

";

        private enum MenuOption
        {
            AdoptMascot = 1,
            ViewMascots,
            InteractMascots,
            Quit
        }

        private enum MascotOption
        {
            Bulbasaur = 1,
            Ivysaur,
            Venusaur,
            Charmander
        }

        private List<Mascot> mascots = new List<Mascot>();

        public void GenerateInteraction()
        {
            name = GetUserName();

            MenuOption userChoice = DisplayMainMenu(name);
            while (userChoice != MenuOption.Quit)
            {
                switch (userChoice)
                {
                    case MenuOption.AdoptMascot:
                        HandleAdoptMascot(name);
                        break;
                    case MenuOption.ViewMascots:
                        ViewMascot();
                        break;
                    case MenuOption.InteractMascots:                 
                            InteractMascot();                      
                        break;
                }

                userChoice = DisplayMainMenu(name);
            }

            Console.WriteLine("The program has been exited.");
        }

        private static string GetUserName()
        {
            Console.WriteLine(WelcomeMessage);
            Console.Write("What is your name?" + Environment.NewLine + "> ");
            return Console.ReadLine();
        }

        private static MenuOption DisplayMainMenu(string name)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------MENU------------------------------------");
            Console.Write($"{name}, Do you wish:"
                + Environment.NewLine + "1 - Adopt a virtual mascot"
                + Environment.NewLine + "2 - See your mascot"
                + Environment.NewLine + "3 - Interact with your mascot"
                + Environment.NewLine + "4 - QUIT"
                + Environment.NewLine + "> ");

            if (int.TryParse(Console.ReadLine(), out int answer) && Enum.IsDefined(typeof(MenuOption), answer))
            {
                return (MenuOption)answer;
            }
            else
            {
                Console.WriteLine("Invalid option, please try again.");
                return DisplayMainMenu(name); // Recursive call to handle invalid input
            }
        }

        private void HandleAdoptMascot(string name)
        {           
            MascotOption? selectedMascot = null;

            do
            {
                selectedMascot = SelectMascot(name);
                if (selectedMascot.HasValue)
                {
                    DisplayMascotOptions(name, selectedMascot.Value, ref hasMascot);
                    if (hasMascot)
                    {
                        var mascot = GetMascotData(selectedMascot.Value);
                        mascots.Add(mascot);
                    }
                }

            } while (!selectedMascot.HasValue || !hasMascot);
        }

        private static MascotOption? SelectMascot(string name)
        {
            Console.WriteLine("");
            Console.WriteLine("---------------------------------- ADOPT MASCOT ------------------------------");
            Console.WriteLine($"{name}, Choose a species: ");
            Console.WriteLine("Bulbasaur [1]" + Environment.NewLine + "Ivysaur [2]" + Environment.NewLine + "Venusaur [3]" + Environment.NewLine + "Charmander [4]");
            Console.Write("Enter a pokémon number > ");

            if (int.TryParse(Console.ReadLine(), out int mascotNumber) && Enum.IsDefined(typeof(MascotOption), mascotNumber))
            {
                return (MascotOption)mascotNumber;
            }
            else
            {
                Console.WriteLine("Choose a valid pokémon number.");
                return null;
            }
        }

        private void DisplayMascotOptions(string name, MascotOption mascotOption, ref bool hasMascot)
        {
            string pokemonUrl = GetPokemonUrl(mascotOption);
            pokemonName = mascotOption.ToString();

            bool menuActive = true; // Controle do menu interno
            while (menuActive)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write($"{name}, Do you wish:"
                    + Environment.NewLine + $"1 - MORE INFORMATION ABOUT {pokemonName}"
                    + Environment.NewLine + $"2 - ADOPT {pokemonName}"
                    + Environment.NewLine + "3 - BACK"
                    + Environment.NewLine + "> ");

                if (int.TryParse(Console.ReadLine(), out int response))
                {
                    switch (response)
                    {
                        case 1:
                            InvokeGet(pokemonUrl);
                            break;
                        case 2:
                            hasMascot = true;
                            Console.WriteLine($"{name}, Mascot successfully adopted, the egg is hatching!!! .......");
                            DisplayHatchingAnimation();
                            menuActive = false; // Sai do menu interno
                            break;
                        case 3:
                            menuActive = false; // Sai do menu interno
                            break;
                        default:
                            Console.WriteLine("Invalid option, please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                }
            }
        }

        private static string GetPokemonUrl(MascotOption mascotOption)
        {
            return mascotOption switch
            {
                MascotOption.Bulbasaur => "https://pokeapi.co/api/v2/pokemon/1/",
                MascotOption.Ivysaur => "https://pokeapi.co/api/v2/pokemon/2/",
                MascotOption.Venusaur => "https://pokeapi.co/api/v2/pokemon/3/",
                MascotOption.Charmander => "https://pokeapi.co/api/v2/pokemon/4/",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private static void DisplayHatchingAnimation()
        {
            Console.WriteLine("       _____ ");
            Console.WriteLine("      /     \\ ");
            Console.WriteLine("     /       \\ ");
            Console.WriteLine("    /         \\ ");
            Console.WriteLine("   /           \\ ");
            Console.WriteLine("  /             \\ ");
            Console.WriteLine(" /               \\ ");
            Console.WriteLine(" |    \\   /     | ");
            Console.WriteLine("  \\    \\ /     / ");
            Console.WriteLine("   \\   (_)    / ");
            Console.WriteLine("    \\       / ");
            Console.WriteLine("     \\_____/ ");
        }

        private void ViewMascot()
        {
            if (hasMascot == false)
            {
                Console.WriteLine("You have no mascots yet!!");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("          Your mascot:             ");
                foreach (var mascot in mascots)
                {
                    Console.WriteLine($"{mascot}");
                }

                InteractMascot();
            }
        }


        //PLAY WITH MASCOT
        public void InteractMascot()
        {
            if (hasMascot == false)
            {
                Console.WriteLine("You have no mascots yet!!");
            }
            else
            {
                bool menuActive2 = true; // Controle do menu interno

                while (menuActive2 == true)
                {

                    Console.Write($"{name}, Do you wish:"
                            + Environment.NewLine + $"1 - See how {pokemonName} is"
                            + Environment.NewLine + $"2 - Feed {pokemonName}"
                            + Environment.NewLine + "3 - Play with " + pokemonName
                            + Environment.NewLine + "4 - BACK"
                            + Environment.NewLine + "> ");

                    if (int.TryParse(Console.ReadLine(), out int response2))
                    {
                        switch (response2)
                        {
                            case 1:
                                mascot.StatusMascot();
                                break;
                            case 2:
                                mascot.FeedMascot();
                                break;
                            case 3:
                                mascot.PLayMascot();
                                break;
                            case 4:
                                menuActive2 = false; // Sai do menu interno
                                break;
                            default:
                                Console.WriteLine("Invalid option, please try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter a number.");
                    }
                }
            }
        }

        
        private static Mascot GetMascotData(MascotOption mascotOption)
        {
            // Fetch the data for the mascot
            try
            {
                var client = new RestClient(GetPokemonUrl(mascotOption));
                var request = new RestRequest("", Method.Get);

                var response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var mascot = JsonSerializer.Deserialize<Mascot>(response.Content);
                    return mascot;
                }
                else
                {
                    Console.WriteLine(response.ErrorMessage);
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Log the exception message
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null; // Retorna null em caso de exceção
            }
        }

        public static void InvokeGet(string pokemonUrl)
        {
            var client = new RestClient(pokemonUrl);
            var request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonObject = JsonSerializer.Deserialize<Mascot>(response.Content);
                Console.WriteLine($"{jsonObject}");
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }
    }
}
