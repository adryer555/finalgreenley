using System.Security.Cryptography.X509Certificates;

namespace txtadvent
{
    public class item
    {
        public string name;
        public string description;
        public string location;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                this.description = value;
            }
        }
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                this.location = value;
            }
        }
        public item(string name, string description, string location)
        {
            this.Name = name;
            this.Description = description;
            this.Location = location;
        }
    }
}