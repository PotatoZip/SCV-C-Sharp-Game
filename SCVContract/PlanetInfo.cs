﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SCVContract {
    internal class PlanetInfo {
        public void InfoKaldir() {
            Console.Clear();

            Dictionary<string, string> infoKaldir = new Dictionary<string, string>() {
                {"Planet:           ", "Kaldir\n" },
                {"Stored data:      ", "Ice desert inhabited by feral herbs of mastodonts\n                   Main transfer station for Protoss transporters\n"},
                {"Mission:          ", "Find one of the rarest minerals in this part of the galaxy called \"Golden orb\"\n"},
                {"Difficulty:       ", "Due to the extreme weather conditions on the planet's surface\n                   you will only have 1 minute to complete the missions"},
                {"                  ", "After this time your suit will be damaged\n\n"},
            };

            foreach(KeyValuePair<string,string> kvp in infoKaldir) {
                Thread.Sleep(1000);
                Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("How to move your SCV suit:\n[W] or [PageUp] ---> Go Up\n[S] or [PageDown] ---> Go Down\n[A] or [PageLeft] ---> Go Left\n[D] or [PageRight] ---> Go Right");
            Console.WriteLine("\n\nPress any key to continue ...");
            Console.ReadKey();
        }
        public void InfoAiur() {      
            Console.Clear();

            Dictionary<string, string> infoAiur = new Dictionary<string, string>() {
                {"Planet:           ", "Aiur\n" },
                {"Stored data:      ", "Home planet of Protoss inhabited by Zergs\n"},
                {"Mission:          ", "Find the missing canister of Terrazite left by the previous expediton\n"},
                {"Difficulty:       ", "Due to the large energy generated by local Nexuses our suit will be 'Boosed'"},
                {"                  ", "Your movement will be increased\n\n"},
            };

            foreach (KeyValuePair<string, string> kvp in infoAiur) {
                Thread.Sleep(1000);
                Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("How to move your SCV suit:\n[W] or [PageUp] ---> Go Up\n[S] or [PageDown] ---> Go Down\n[A] or [PageLeft] ---> Go Left\n[D] or [PageRight] ---> Go Right");
            Console.WriteLine("\n\nPress any key to continue ...");
            Console.ReadKey();
        }
        public void InfoChar() {
            Console.Clear();

            Dictionary<string, string> infoChar = new Dictionary<string, string>() {
                {"Planet:           ", "Char\n" },
                {"Stored data:      ", "Vulcanic planet\n                   The main concentration in this part of the galaxy\n"},
                {"Mission:          ", "Last week we received a request to evacuate the lost miners."},
                {"                  ", "Find them in the intricate tunnels\n"},
                {"Difficulty:       ", "You have to use tunnels to find your way\n"},
            };

            foreach (KeyValuePair<string, string> kvp in infoChar) {
                Thread.Sleep(1000);
                Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("How to move your SCV suit:\n[W] or [PageUp] ---> Go Up\n[S] or [PageDown] ---> Go Down\n[A] or [PageLeft] ---> Go Left\n[D] or [PageRight] ---> Go Right");
            Console.WriteLine("\n\nPress any key to continue ...");
            Console.ReadKey();
        }
    }
}
