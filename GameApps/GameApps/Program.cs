using GameApps;
using System;

class Program
{
    static void Main()
    {
        GameMap gameApps = new GameMap("map.txt");

        Console.Clear();
        DrawMap(gameApps);

        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(intercept: true).Key;
                int deltaX = 0;
                int deltaY = 0;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        deltaX = -1;
                        break;
                    case ConsoleKey.RightArrow:
                        deltaX = 1;
                        break;
                    case ConsoleKey.UpArrow:
                        deltaY = -1;
                        break;
                    case ConsoleKey.DownArrow:
                        deltaY = 1;
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
                gameApps.MovePlayer(deltaX, deltaY);
                DrawMap(gameApps);
            }
        }
    }

    static void DrawMap(GameMap gameMap)
    {
        Console.Clear();
        for (int y = 0; y < gameMap.Height; y++)
        {
            for (int x = 0; x < gameMap.Width; x++)
            {
                char cell = gameMap.GetCell(x, y);
                Console.Write(cell);
            }
            Console.WriteLine();
        }
    }
}