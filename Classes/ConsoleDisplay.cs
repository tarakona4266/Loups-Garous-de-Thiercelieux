using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Loups_Garous_de_Thiercelieux_console.Classes
{
    public static class ConsoleDisplay
    {
        public static void MainTitle()
        {
            Console.WriteLine(" +----------------------------------+");
            Console.WriteLine(" | The Werewolves of Millers Hollow |");
            Console.WriteLine(" +----------------------------------+\n");
        }

        public static void ClearLine(int nbLines = 1)
        {
            int lineNb = Console.CursorTop;
            if (lineNb >= nbLines)
            {
                lineNb -= nbLines;
            }
            Console.SetCursorPosition(0, lineNb);
            for (int i = 0; i <= nbLines; i++)
            {
                Console.Write(new string(' ', Console.BufferWidth));
                Console.SetCursorPosition(0, lineNb + i);
            }
            Console.SetCursorPosition(0, lineNb);

        }

        public static void PrintPlayers(List<Player> Players)
        {
            int nbColumn = Players.Count;

            int columnWidth = 12;
            int wordWidht;
            int comp;

            foreach (Player player in Players)
            {
                if (player.isAlive) { Console.ForegroundColor = ConsoleColor.White; }
                else { Console.ForegroundColor = ConsoleColor.Gray; }

                if (player.indexInPlayerList < 10) { Console.Write(" "); } // for alignment
                Console.Write($" [{player.indexInPlayerList}] ");
                Console.Write($"- {player.name}");
                if (!player.isAlive) { Console.Write($" - {player.PrintRole}"); }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Narrrate(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[Narrator] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Thread.Sleep(1000); // ugly but will do the job for now
        }
    }
}
