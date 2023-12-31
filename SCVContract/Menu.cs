﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace SCVContract {
    internal class Menu {

        Planets planets = new Planets();
        //Save save = new Save();
        public void StartGame(Menu menu) {
        Console.WriteLine(@" $$$$$$\   $$$$$$\  $$\    $$\        $$$$$$\   $$$$$$\  $$\   $$\ $$$$$$$$\ $$$$$$$\   $$$$$$\   $$$$$$\ $$$$$$$$\ 
$$  __$$\ $$  __$$\ $$ |   $$ |      $$  __$$\ $$  __$$\ $$$\  $$ |\__$$  __|$$  __$$\ $$  __$$\ $$  __$$\\__$$  __|
$$ /  \__|$$ /  \__|$$ |   $$ |      $$ /  \__|$$ /  $$ |$$$$\ $$ |   $$ |   $$ |  $$ |$$ /  $$ |$$ /  \__|  $$ |   
\$$$$$$\  $$ |      \$$\  $$  |      $$ |      $$ |  $$ |$$ $$\$$ |   $$ |   $$$$$$$  |$$$$$$$$ |$$ |        $$ |   
 \____$$\ $$ |       \$$\$$  /       $$ |      $$ |  $$ |$$ \$$$$ |   $$ |   $$  __$$< $$  __$$ |$$ |        $$ |   
$$\   $$ |$$ |  $$\   \$$$  /        $$ |  $$\ $$ |  $$ |$$ |\$$$ |   $$ |   $$ |  $$ |$$ |  $$ |$$ |  $$\   $$ |   
\$$$$$$  |\$$$$$$  |   \$  /         \$$$$$$  | $$$$$$  |$$ | \$$ |   $$ |   $$ |  $$ |$$ |  $$ |\$$$$$$  |  $$ |   
 \______/  \______/     \_/           \______/  \______/ \__|  \__|   \__|   \__|  \__|\__|  \__| \______/   \__|   
                                                                                                                    


                            ");
            Console.WriteLine("[1] ---> New game\n[2] ---> Load game");
            while(true) {
                try {
                    string ans = ReadLine();
                    if(ans == "1") {
                        menu.NewGame();
                        break;
                    }
                    else if(ans == "2") {
                        //menu.LoadGame();
                        Console.WriteLine("Will be added");
                    }
                    else {
                        Console.WriteLine("Wrong input");
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
            ReadKey();
        }

        public void NewGame() {
            Console.Clear();
            Console.WriteLine("Launch of the adjutant is underway ...");
            Thread.Sleep(500);
            Console.WriteLine(".");
            Thread.Sleep(2000);
            Console.WriteLine(".");
            Thread.Sleep(2000);
            Console.WriteLine(".");
            Thread.Sleep(2000);
            Console.Clear();
            TypeText("Hello\n");
            Thread.Sleep(1000);
            TypeText("My name is Colonel and I am your personal adjutant\n");
            Thread.Sleep(1000);
            TypeText("You are certainly a new employee of the Mobius Industries hired as an SCV worker\n");
            Thread.Sleep(1000);
            TypeText("Your boss entrusts you with 3 missions within your contract after the complition of which you will be paid\n");
            Thread.Sleep(1000);
            TypeText("You can start whenever you want without any specific order\n");
            Thread.Sleep(1000);
            TypeText("GOOD LUCK!!!\n\n");
            Console.WriteLine("Enter any key to continue...");
  
            Console.ReadKey();
            planets.SelectPlanet();
        }
        public void TypeText(string text) {
            foreach (char c in text) {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine();
        }
        /*
        public void LoadGame() {
            save.SaveGame();
        }
        */
    }
}
