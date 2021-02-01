using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class ConsoleGame
    {
        Player player;
        Room[,] world;
        Random random = new Random();

        public void Play()
        {
            CreatePlayer();
            CreateWorld();
            DisplayWorld();
            DisplayInfo();
            do
            {
                AskForMovement();
                Console.Clear();
                DisplayWorld();
                DisplayInfo();
                CheckPosForItems();
                CheckPosForMonsters();//Lägg till senare
            } while (player.Health > 0);

            GameOver();
        }

        private void CheckPosForMonsters()
        {
            if (world[player.X, player.Y].Monster != null)
            {
                Fight(world[player.X, player.Y].Monster);
            }
        }

        private void Fight(Monster monster)
        {
            do
            {
                player.Attack(monster);
                Console.WriteLine($"Hero attacked {monster.Name} and dealt {player.Dmg} damage");
                monster.Attack(player);
                Console.WriteLine($"{monster.Name} attacked hero and dealt {monster.Dmg} damage");
                Console.ReadKey(true);
            } while (player.Health > 0 && monster.Health > 0);

            if (monster.Health <=0)
            {
                Console.WriteLine($"{monster.Name} killed");
                world[player.X, player.Y].Monster = null;
                Console.ReadKey(true);
            }
            
        }

        private void CheckPosForItems()
        {
            if (world[player.X, player.Y].Item != null)
            {
                player.backpack.Add(world[player.X, player.Y].Item);
                world[player.X, player.Y].Item = null;
            }
        }

        private void CreatePlayer()
        {
            player = new Player( 0, 0);
        }

        private void CreateWorld()
        {
            world = new Room[20, 5];

            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    world[x, y] = new Room();

                    int percentage = random.Next(0, 100);
                    if (percentage < 10)
                        world[x, y].Monster = new Goblin();
                    else if (percentage < 20)
                        world[x, y].Item = new Weapon("Sword", 5);
                    else if (percentage < 30)
                        world[x, y].Item = new Potion("Healing Potion", 5);
                }
            }
            world[0, 0].Item = null;
            world[0, 0].Monster = null;
            world[world.GetLength(0) - 1, world.GetLength(1) - 1].Monster = new Dragon();
        }

        private void DisplayWorld()
        {
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    Room room = world[x, y];
                    if (player.X == x && player.Y == y)
                        Console.Write("P");
                    else if (room.Monster != null)
                        Console.Write(world[x, y].Monster.Name[0]);
                    else if (room.Item != null)
                        Console.Write("I");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }

        private void DisplayInfo()
        {
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine("Items : ");
            foreach (var item in player.backpack)
            {
                Console.WriteLine($"{item.Name}");
            }
        }

        private void AskForMovement()
        {
            int newX = player.X;
            int newY = player.Y;
            bool isValidKey = true;

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow: newX++; break;
                case ConsoleKey.LeftArrow: newX--; break;
                case ConsoleKey.UpArrow: newY--; break;
                case ConsoleKey.DownArrow: newY++; break;
                default: isValidKey = false; break;
            }

            if (isValidKey &&
                newX >= 0 && newX < world.GetLength(0) &&
                newY >= 0 && newY < world.GetLength(1))
            {
                player.X = newX;
                player.Y = newY;
            }
        }

        private void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game over...");
            Console.ReadKey();
            Play();
        }
    }
}
