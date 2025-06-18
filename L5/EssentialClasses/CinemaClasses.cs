using System.Xml.Serialization;

namespace EssentialClasses
{
    [Serializable]
    public class CinemaBuilding
    {
        [XmlAttribute]
        public string CinemaName { get; set; }
        public string CinemaAdress { get; set; }
        public List<Film> Films { get; set; } = new List<Film>();

        public CinemaBuilding() { }
    }

    [Serializable]
    public class Film
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public List<Session> Sessions { get; set; } = new List<Session>();

        public Film() { }
    }

    [Serializable]
    public class Session
    {
        public string Time { get; set; }
        public uint TicketPrice { get; set; }
        public uint TicketPurchases { get; set; }
        public Session() { }
    }

}
