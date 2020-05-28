namespace txtadvent
{
    public class Room
    {
        public string refName;
        public string shortname;
        public bool visited;
        public string roomDescription;
        public string roomNorth;
        public string roomEast;
        public string roomSouth;
        public string roomWest;
        public string roomUp;
        public string roomDown;

        public string RefName
        {
            get
            {
                return refName;
            }
            set
            {
                this.refName = value;
            }
        }
        public string ShortName
        {
            get
            {
                return shortname;
            }
            set
            {
                this.shortname = value;
            }
        }
        public bool Visited
        {
            get
            {
                return visited;
            }
            set
            {
                this.visited = value;
            }
        }
        public string RoomDescription
        {
            get
            {
                return roomDescription;
            }
            set
            {
                this.roomDescription = value;
            }
        }
        public string RoomNorth
        {
            get
            {
                return roomNorth;
            }
            set
            {
                this.roomNorth = value;
            }
        }
        public string RoomEast
        {
            get
            {
                return roomEast;
            }
            set
            {
                this.roomEast = value;
            }
        }
        public string RoomSouth
        {
            get
            {
                return roomSouth;
            }
            set
            {
                this.roomSouth = value;
            }
        }
        public string RoomWest
        {
            get
            {
                return roomWest;
            }
            set
            {
                this.roomWest = value;
            }
        }
        public string RoomUp
        {
            get
            {
                return roomUp;
            }
            set
            {
                this.roomUp = value;
            }
        }
        public string RoomDown
        {
            get
            {
                return roomDown;
            }
            set
            {
                this.roomDown = value;
            }
        }

        public Room(string refName, string shortname, bool visited, string roomDescription, string roomNorth, string roomEast, string roomSouth, string roomWest, string roomUp, string roomDown)
        {
        this.RefName = refName;
        this.ShortName = shortname;
        this.Visited = visited;
        this.RoomDescription = roomDescription;
        this.RoomNorth = roomNorth;
        this.RoomEast = roomEast;
        this.RoomSouth = roomSouth;
        this.RoomWest = roomWest;
        this.RoomUp = roomUp;
        this.RoomDown = roomDown;


        }
    }
}