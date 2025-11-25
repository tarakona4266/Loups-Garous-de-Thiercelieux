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
                Console.Write($" [{player.indexInPlayerList}] ");
                if (player.indexInPlayerList < 10) { Console.Write(" "); }
                Console.Write($"- {player.name}");
                Console.WriteLine();
            }
        }
        public static void Narrrate(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[Narrator] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
        }
    }
}
