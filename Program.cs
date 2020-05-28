
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtadvent
{

    class Program
    {
        
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<item> items = new List<item>();
            #region Items
            items.Add(new item("Rocky", "A Rock", "store"));
            items.Add(new item("Hotdog", "Weiner In A Bun", "store"));
            #endregion

            #region Template
            rooms.Add(new Room(
             "", // ref name
            "",  //shortname
             false,  //visited
             "", //description
            "None", // Room North
            "None", // room South
             "None", // room east
            "None",  //room west
             "None",//  room up
             "None" // room down
              ));
            #endregion
            #region Store
            rooms.Add(new Room(
             "store", // ref name
             "Store", // shortname
             false, // visited
             "You can buy anything you want and more at the town store", //description
             "r", // Room North
             "Town", // room South
             null, // room east
             "", // room west
             null, // room up
             null // room down
              ));
            #endregion
            #region Town
            rooms.Add(new Room(
             "town", // ref name
             "Town", // shortname
             false, // visited
             "You can tell this place was once buzzing with activity, but it seems dead now.", //description
             "Store", // Room North
             null, // room South
             "Highway", // room east
             "", // room west
             null, // room up
             null // room down
              ));

            #endregion
            #region Highway
            rooms.Add(new Room(
             "highway", // ref name
             "Highway", // shortname
             false, // visited
             "The old highway ends here, you can see the town and some farms in the distance.", //description
             null, // Room North
             "Orchard", // room South
             "Cornfield", // room east
             "Town", // room west
             null, // room up
             null // room down
              ));
            #endregion
            #region Highway
            rooms.Add(new Room(
             "highway", // ref name
             "Highway", // shortname
             false, // visited
             "The old highway ends here, you can see the town and some farms in the distance.", //description
             null, // Room North
             "Orchard", // room South
             "Cornfield", // room east
             "Town", // room west
             null, // room up
             null // room down
              ));
            #endregion
            #region Orchard
            rooms.Add(new Room(
             "orchard", // ref name
             "Orchard", // shortname
             false, // visited
             "This is an apple orchard, but it appears as if its been untouched for years.", //description
             "Highway", // Room North
             null, // room South
             "Flower Field", // room east
             null, // room west
             null, // room up
             null // room down
              ));
            #endregion

            string Balance = "0$";
            string curRoomIdentifier = "store";
            Room curRoom;
            string command = "";
            string oldLocation = "";
            Console.WriteLine("Welcome");
            Console.WriteLine("Valid Commands, N, S, E, W, U, D, Q");
            do
            {
                curRoom = rooms.Find(x => x.refName == curRoomIdentifier);
                if (curRoom == null)
                {
                    Console.WriteLine("ERROR: No location {0} found!", curRoomIdentifier);
                    curRoomIdentifier = oldLocation;
                    curRoom = rooms.Find(x => x.refName == curRoomIdentifier);
                }

                if (curRoom.visited == false)
                {
                    Console.WriteLine(curRoom.roomDescription);
                    curRoom.visited = true;
                }
                if (items.Find(x => x.location == curRoomIdentifier) != null)
                    Console.Write("You see: ");
                foreach (item stuff in items)
                {
                    if (stuff.location == curRoomIdentifier)
                    {
                        Console.WriteLine(stuff.name + " ");
                    }
                }

                Console.Write("The Available directions are: ");
                if (curRoom.roomNorth != null) Console.Write("North,  ");
                if (curRoom.roomSouth != null) Console.Write("South,  ");
                if (curRoom.roomEast != null) Console.Write("East,  ");
                if (curRoom.roomWest != null) Console.WriteLine("West ");

                Console.WriteLine("Command Please: ");
                command = Console.ReadLine();
                if (command.ToUpper() == "N" || command.ToUpper() == "S" || command.ToUpper() == "E" || command.ToUpper() == "W" || command.ToUpper() == "U" || command.ToUpper() == "D" || command.ToUpper() == "Location" || command.ToUpper() == "Balance")

                {
                    if (curRoom.roomNorth != null)
                        curRoomIdentifier = curRoom.roomNorth;
                    else Console.WriteLine("You baffoon, you cannot go this way!");
                }
                else if (command.ToUpper() == "S")
                {
                    if (curRoom.roomSouth != null)
                        curRoomIdentifier = curRoom.roomSouth;
                    else Console.WriteLine("You baffoon, you cannot go this way!");
                }
                else if (command.ToUpper() == "E")
                {
                    if (curRoom.roomEast != null)
                        curRoomIdentifier = curRoom.roomEast;
                    else Console.WriteLine("You baffoon, you cannot go this way!");
                }
                else if (command.ToUpper() == "W")
                {
                    if (curRoom.roomWest != null)
                        curRoomIdentifier = curRoom.roomWest;
                    else Console.WriteLine("You baffoon, you cannot go this way!");
                }
                else if (command.ToUpper() == "U")
                {
                    if (curRoom.roomUp != null)
                        curRoomIdentifier = curRoom.roomUp;
                    else Console.WriteLine("You baffoon, you cannot go this way!");
                }
                else if (command.ToUpper() == "D")
                {
                    if (curRoom.roomDown != null)
                        curRoomIdentifier = curRoom.roomDown;
                    else Console.WriteLine("You baffoon, you cannot go this way!");
                }

                else if (command == "Location")
                {
                    Console.WriteLine(curRoom.refName);
                }
                else if (command == "Balance")
                {
                    Console.WriteLine(Balance);
                }
                //strings
                string[] commandWords = new string[10];
                commandWords = splitCommand(command);
                if (commandWords[0] == "GET")
                {
                    item tempItem;
                    //Console.WriteLine("looking for {0}.", commandWords[1]);
                    if (items.Find(x => (x.location == curRoomIdentifier && x.name.ToUpper() == commandWords[1])) != null)
                    {
                        Console.WriteLine("Found a {0}.", commandWords[1]);
                        tempItem = items.Find(x => (x.location == curRoomIdentifier && x.name.ToUpper() == commandWords[1]));

                    }
                    else
                    {
                        Console.WriteLine("Could not find a {0}. do you know what you are doing?");
                    }
                }



            }
            while (command.ToUpper() != "Q");
            Console.WriteLine("Bye");

            string[] splitCommand(string Command)
            {
                string[] words = new string[10];
                int spacePos = command.IndexOf(' ');
                if (spacePos >= 0)
                {
                    words[0] = command.Substring(0, spacePos);
                    words[1] = command.Substring(spacePos).Trim();
                }
                else { words[0] = command; }
                return words;

            }


        }
    }
}