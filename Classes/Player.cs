using Loups_Garous_de_Thiercelieux_console.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loups_Garous_de_Thiercelieux_console.Classes
{
    public class Player
    {
        public bool isHumain;
        public bool isAlive = true;
        public string name;
        public Role role;
        public int indexInPlayerList;
        public Player(string name, bool isHumain, int index)
        {
            this.isHumain = isHumain;
            this.name = name;
            indexInPlayerList = index;
        }

        public void PrintRole()
        {
            switch (role)
            {
                case Role.Werewolf:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Role.Cupido:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case Role.FortuneTeller:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Role.Hunter:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Role.Witch:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Role.LittleGirl:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case Role.Sheriff:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default: Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.Write(role);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public int TownVote(List<Player> players)
        {
            int choice;
            if (isHumain)
            {
                Console.WriteLine("Choose someone to sacrifice :");
                while (true)
                {
                    string? answer = Console.ReadLine();
                    if (int.TryParse(answer, out choice))
                    {
                        if (choice >= 0 && choice < players.Count)
                        {
                            if (choice != indexInPlayerList)
                            {
                                ConsoleDisplay.ClearLine(2);
                                break;
                            }
                            else
                            {
                                ConsoleDisplay.ClearLine(2);
                                Console.WriteLine("Invalid input : you cannot choose yourself");
                            }
                        }
                        else
                        {
                            ConsoleDisplay.ClearLine(2);
                            Console.WriteLine($"Invalid input : pLease enter a number between 0 and {players.Count}");
                        }
                    }
                    else
                    {
                        ConsoleDisplay.ClearLine(2);
                        Console.WriteLine("Invalid input : pLease enter a number");
                    }
                }
                Console.WriteLine($"{name} has voted {choice}");
                return choice;
            }
            else
            {
                do
                { choice = GlobalRandom.GetRandom(players.Count);
                } while (choice == indexInPlayerList);
            }
            Console.WriteLine($"{name} has voted {choice}");
            return choice;
        }
    }
}
