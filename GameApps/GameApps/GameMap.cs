using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApps
{
    public class GameMap
    {
        private char[,] map;
        private int playerX;
        private int playerY;

        public int Width { get; private set; }
        public int Height { get; private set; }

        public GameMap (string mapFileName)
        {
            LoadMap(mapFileName);
        }

        private void LoadMap (string mapFileName)
        {
            string[] lines = File.ReadAllLines(mapFileName);
            Height = lines.Length;
            Width = lines[0].Length;

            map = new char[Width, Height];

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    char cell = lines[y][x];
                    map[x, y] = cell;

                    if (cell == '@')
                    {
                        playerX = x;
                        playerY = y;
                    }
                }
            }
        }

        public void MovePlayer(int deltaX, int deltaY)
        {
            int newX = playerX + deltaX;
            int newY = playerY + deltaY;

            if (islnBounds(newX, newY) && map[newX,newY] != '#') {
                map[playerX, playerY] = ' ';
                playerX = newX;
                playerY = newY;
                map[playerX, playerY] = '@';
            }
        }

        private bool islnBounds(int x, int y)
        {
            return x >= 0 && y >= 0 && x < Width && y < Height;
        }

        public char GetCell(int x, int y)
        {
            if (islnBounds(x, y)) {
                return map[x, y];
            }
            else
            {
                return ' ';
            }
        }
    }
}
