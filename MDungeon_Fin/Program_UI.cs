using MindDungeon_Lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MDungeon_Fin
{
    public class Program_UI
    {

        private static bool PlayerDeath;
        private static string attack;
        private static string block;
        public static bool HasCompletedRoom1 = false;
        public static bool HasCompletedRoom2 = false;
        public static bool HaEnteedDoor1 = false;
      

        public static void Run()
        {
            bool IsLockedInRoom = false;
            Player player = new Player();
            bool IsRunning = true;
            while (IsRunning)
            {
                if (!PlayerDeath)
                {


                    Console.WriteLine("=====WELCOME TO THE MIND DUNGEON=====");
                    Console.WriteLine("Please select a character type\n" +
                        "1. Warrior\n" +
                        "2. Archer\n" +
                        "3. Wizard");

                    var UserInput = Console.ReadLine();
                    Console.Clear();
                    switch (UserInput)
                    {
                        case "1":
                            Warrior warrior = new Warrior();
                            player.SelectedCharacter = warrior;
                            break;
                        case "2":
                            Archer archer = new Archer();
                            player.SelectedCharacter = archer;
                            break;
                        case "3":
                            Wizzard wizard = new Wizzard();
                            player.SelectedCharacter = wizard;
                            break;
                        default:
                            Console.WriteLine("Invalid Selection. Press any key to continue...");
                            Console.ReadKey();
                            break;
                    }
                    Console.WriteLine("First we need your characters name, hit enter when your done...:");
                    player.Name = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("There is a big door ahead of you... Press the  'y' key to continue?");
                    var userInputY = Console.ReadLine();
                    if (userInputY =="Y".ToLower())
                    {
                         IsLockedInRoom = true;
                        while (IsLockedInRoom)
                        {
                            


                           
                            switch (userInputY)
                            {
                                case "y":
                                    Room room = new Room(new List<string> { "Door1", "Door2", "Door3", "Door4" });

                                    Console.WriteLine("Please select the following\n" +
                                        "1. Door 1\n" +
                                        "2. Door 2\n" +
                                        "3. Door 3\n" +
                                        "4. Door 4\n");


                                    var UserInputDoor = Console.ReadLine();
                                    switch (UserInputDoor)
                                    {
                                        case "1":
                                            IsLockedInRoom = SpiderFight();
                                            break;
                                        case "2":
                                            IsLockedInRoom = DeadEnd();
                                            break;
                                        case "3":
                                            IsLockedInRoom = LockedDoor();
                                            break;
                                        case "4":
                                            IsLockedInRoom = QuickSandTrap();

                                            break;
                                        default:
                                            Console.WriteLine("Invalid Selection. Please try again.");
                                            Console.ReadKey();
                                            break;
                                    }
                                    //Console.WriteLine("You enter a Large room. The door locks behind you.");
                                    break;
                                default:
                                    Console.WriteLine("Invalid Selection. Please try again.");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("...Scarry Catttt!");
                        BackToMainMenu();
                    }
                    if (!PlayerDeath && HasCompletedRoom1)
                    {
                        Console.Clear();
                        Console.WriteLine("You have made it to the next room.\n" +
                            "You are faced with 3 doors\n" +
                            "which will you chooose\n" +
                            "1. Door 1\n" +
                            "2. Door 2\n" +
                            "3. Door 3");


                        var userInputDoor = Console.ReadLine();
                        switch (userInputDoor)
                        {
                            case "1":
                                IsLockedInRoom = LavaTrap();
                                break;
                            case "2":
                                IsLockedInRoom = GiantSnake();
                                break;
                            case "3":
                                SpikePit();
                                break;

                            default:
                                Console.WriteLine("You have made and Invalid selection. Please try again.");
                                break;
                        }
                    }
                    if (!PlayerDeath && HasCompletedRoom2)
                    {
                        Console.Clear();
                        Console.WriteLine("You have made it to the final room. Will you get the treasure?\n" + "You have 3 more doors to choose from.\n" +
                            "What's your first move?\n" +
                            "1. Door 1\n" +
                            "2. Door 2\n" +
                            "3. Door 3");

                        var UserInputDoor = Console.ReadLine();
                        switch (UserInputDoor)
                        {
                            case "1":
                                 GiantWithBaseballBat(); //you will have to start over
                                break;
                            case "2":
                                LavaPit(); //you will have to start over
                                break;
                            case "3":
                                IsLockedInRoom = GiantDragonWithMoney();
                                break;
                            default:
                                Console.WriteLine("Invalid Input, try again");
                                break;
                        }
                    }
                }
                else
                {
                    BackToMainMenu();
                }

            }




        }
      
        public static void BackToMainMenu()
        {
            Console.WriteLine("Do you want to try again y/n?");
            var UserInputTryAgain = Console.ReadLine().ToLower();
            switch (UserInputTryAgain)
            {
                case "y":
                    PlayerDeath = false;
                    Console.Clear();
                    HasCompletedRoom1 = false;
                    HasCompletedRoom2 = false;
                    break;
                case "n":
                    Console.WriteLine("Thanks for playing, press any key to continue.");
                    HasCompletedRoom1 = false;
                    HasCompletedRoom2 = false;
                    break;
                default:
                    Console.WriteLine("Invalid key. Press any key to continue");
                    Console.ReadKey();
                    break;
            }

        }
        private static void GiantWithBaseballBat()
        {
            Console.Clear();
            //put description here...
            var nameOfDescriptionOfScene = "asdngskldfndfkn";
            TheSlowLetterMaker(nameOfDescriptionOfScene);
;            Console.ReadKey();
            BackToMainMenu();
        }

        private static void LavaPit()
        {
            Console.Clear();
            //put description here...
            Console.ReadKey();
            BackToMainMenu();

        }

        private static bool GiantDragonWithMoney()
        {
            Console.Clear();
            var FinPartOfStory = "sdkfnsdlkfnsdlfknsldfnsdlkfnsdlknfsdkl;fnsdnfsdf0";
            TheSlowLetterMaker(FinPartOfStory);
            Console.ReadKey();
            return false;
        }

        private static void TheSlowLetterMaker(string FinPartOfStory)
        {
            foreach (var letter in FinPartOfStory)
            {
                Thread.Sleep(25);
                Console.Write(letter);
            }
        }

        public bool IsDead()
        {
            PlayerDeath = true;
            return false;
        }

        private static void SpikePit()
        {
            Console.Clear();
            Console.WriteLine("You have fallen in a pit of Spikes. You are skeward to death. Try again.");
            BackToMainMenu();
        }

        private static bool GiantSnake()
        {
            Console.Clear();
            var BattleDescription="You have stumble upon a giant snake. Defeat the snake to get to the next room.\n" +
                "The snake has launced a strike at you but you were able to get out of the way in time.\n" +
                "You retalliate with your attack and take half the snake's hit point.\n" +
                "The snakes now wrapping around you.\n" +
                "You use your strongest attack and defeat the snake.\n" +
                "Move on to the final room.";
            TheSlowLetterMaker(BattleDescription);
            Console.ReadKey();
            HasCompletedRoom2 = true;
            return false;
        }

        private static bool LavaTrap()
        {
            Console.Clear();
            Console.WriteLine("You've been melted by Lava. Start over.");
            PlayerDeath = true;
            return false;
        }


        private static bool QuickSandTrap()
        {
            Console.Clear();
            Console.WriteLine("You're trapped in Quick Sand. Start over.");
            PlayerDeath = true;
            BackToMainMenu();
            return false;
        }

        private static bool LockedDoor()
        {
            Console.Clear();
            Console.WriteLine("This door is locked and the lock is rusted... Try another door");
            Console.ReadKey();
            return true;
        }

        private static bool DeadEnd()
        {
            Console.Clear();
            Console.WriteLine("This is a Dead End, Try again.Press any key....");
            Console.ReadKey();
            return true;
        }

        private static bool SpiderFight()
        {

            Console.Clear();
            var spiderFight="You have stumble upon a giant spider. Defeat the spider to get to the next room.\n" +
                "The spider spat venom at  you but you dodged it.\n" +
                "You attack and defeat the spider and defested it.\n" +
                "Move to the next room.";
            TheSlowLetterMaker(spiderFight);
            Console.ReadKey();
            HasCompletedRoom1 = true;
            return false;
        }
    }
}
