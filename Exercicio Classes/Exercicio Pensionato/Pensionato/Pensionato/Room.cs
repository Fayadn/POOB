

namespace Pensionato
{
    class Room
    {
        public string Name { get; set; }
        public string Mail { get; set; }

        public Room(string name, string mail)
        {
            Name = name;
            Mail = mail;
        }
        public override string ToString()
        {
            return Name + ", " + Mail;
        }

    }
}
