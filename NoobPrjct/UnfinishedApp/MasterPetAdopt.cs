using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NoobPrjct.UnfinishedApp
{
    public class MasterPetAdopt
    {
        private int maxPets = 8;
        private char inputUser;
        private char optionSelected;
        private string[,] ourAnimals;

        private void assignProperties()
        {
            ourAnimals = new string[maxPets, 6];
            ModelPet modelPet = new ModelPet();
            for (int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:
                        modelPet.Id = "E1";
                        modelPet.Spesies = "Elephant";
                        modelPet.Usia = 10;
                        modelPet.Characteristics = "Large, intelligent, gentle";
                        modelPet.Traits = "Good memory, family-oriented";
                        modelPet.Name = "Dumbo";
                        break;
                    case 1:
                        modelPet.Id = "L2";
                        modelPet.Spesies = "Lion";
                        modelPet.Usia = 5;
                        modelPet.Characteristics = "Strong, brave, social";
                        modelPet.Traits = "Leader of the pride";
                        modelPet.Name = "Simba";
                        break;
                    case 2:
                        modelPet.Id = "T3";
                        modelPet.Spesies = "Tiger";
                        modelPet.Usia = 4;
                        modelPet.Characteristics = "Stealthy, strong, solitary";
                        modelPet.Traits = "Hunter, territorial";
                        modelPet.Name = "Shere Khan";
                        break;
                    default:
                        modelPet.Id = "";
                        modelPet.Spesies = "Unknown";
                        modelPet.Usia = 0;
                        modelPet.Characteristics = "Unknown";
                        modelPet.Traits = "Unknown";
                        modelPet.Name = "Unknown";
                        break;
                }

                ourAnimals[i, 0] = $"ID #: {modelPet.Id}";
                ourAnimals[i, 1] = $"Species: {modelPet.Spesies}";
                ourAnimals[i, 2] = $"Usia Hewan: {modelPet.Usia}";
                ourAnimals[i, 3] = $"Karakteristik Hewan: {modelPet.Characteristics}";
                ourAnimals[i, 4] = $"Kelebihan Hewan: {modelPet.Traits}";
                ourAnimals[i, 5] = $"Nama: {modelPet.Name}";
            }
        }

        public void mainMenu()
        {
            assignProperties();
            do
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
                Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
                Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
                Console.WriteLine(" 5. Edit an animal’s age");
                Console.WriteLine(" 6. Edit an animal’s personality description");
                Console.WriteLine(" 7. Display all cats with a specified characteristic");
                Console.WriteLine(" 8. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type 9 to exit the program)");


                inputUser = Console.ReadKey(true).KeyChar;
                if (inputUser != ' ')
                {
                    optionSelected = userSelected(inputUser);
                    if (inputUser == '9')
                    {
                        Console.Write("Exit the Program");
                    }
                    Console.Write("\nPress the Enter key to continue...");
                }
                Console.ReadLine();

            } while (optionSelected != '9');
        }

        private char userSelected(char option)
        {
            switch (option)
            {
                case '1':
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i, 0] != null && ourAnimals[i, 0] != "ID #: ")
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 6; j++)
                            {
                                Console.WriteLine(ourAnimals[i, j]);
                            }
                        }
                    }
                    break;
                case '2':
                    Console.WriteLine("this app feature(2) is coming soon - please check back to see progress.");
                    break;
                case '3':
                    Console.WriteLine("this app feature(3) is coming soon - please check back to see progress.");
                    break;
                case '4':
                    Console.WriteLine("this app feature(4) is coming soon - please check back to see progress.");
                    break;
                case '5':
                    Console.WriteLine("this app feature(5) is coming soon - please check back to see progress.");
                    break;
                case '6':
                    Console.WriteLine("this app feature(6) is coming soon - please check back to see progress.");
                    break;
                case '7':
                    Console.WriteLine("this app feature(7) is coming soon - please check back to see progress.");
                    break;
                case '8':
                    Console.WriteLine("this app feature(8) is coming soon - please check back to see progress.");
                    break;
                default:
                    break;
            }
            return option;
        }
    }
}
