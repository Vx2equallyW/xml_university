namespace EssentialClasses
{
    public interface CinemaInterface
    {
        void ModifyCinemaInfo(string name, string adress);
        void AddFilmToCinema(Film film);
        static void ModifyFilmInfo(Film film, string name, string genre)
        {
            film.Name = name;
            film.Genre = genre;
        }
        static void AddSessionToFilm(Film film, Session session)
        {
            film.Sessions.Add(session);
        }
        static void ModifyFilmSessionInfo(Session session, string time, uint ticketPrice, uint ticketPurchases)
        {
            session.Time = time;
            session.TicketPrice = ticketPrice;
            session.TicketPurchases = ticketPurchases;
        }
    }
    public class AdapterCinema : CinemaBuilding, CinemaInterface
    {

        public AdapterCinema() { }
        public AdapterCinema(string name, string adress) : base()
        {
            CinemaName = name;
            CinemaAdress = adress;
            Films = new List<Film>();
        }
        public void ModifyCinemaInfo(string name, string adress)
        {
            this.CinemaName = name;
            this.CinemaAdress = adress;
        }
        public void AddFilmToCinema(Film film)
        {
            this.Films.Add(film);
        }
        public static void ModifyFilmInfo(Film film, string name, string genre)
        {
            film.Name = name;
            film.Genre = genre;
        }
        public static void AddSessionToFilm(Film film, Session session)
        {
            film.Sessions.Add(session);
        }
        public static void ModifyFilmSessionInfo(Session session, string time, uint ticketPrice, uint ticketPurchases)
        {
            session.Time = time;
            session.TicketPrice = ticketPrice;
            session.TicketPurchases = ticketPurchases;
        }
    }
    /*
    public interface FilmInterface
    {
        void Modify(string name, string genre);
        void AddSession(Session session);
    }
    public class AdapterFilm : Film, FilmInterface
    {
        public AdapterFilm(string name, string genre) : base()
        {
            Name = name;
            Genre = genre;
            Sessions = new List<Session>();
        }
        void FilmInterface.Modify(string name, string genre)
        {
            this.Name = name;
            this.Genre = genre;
        }
        void FilmInterface.AddSession(Session session)
        {
            this.Sessions.Add(session);
        }
    }

    public interface SessionInterface
    {
        void Modify(string time, uint ticketPrice, uint ticketPurchases);
    }
    public class AdapterSession : Session, SessionInterface
    {
        public AdapterSession(string time, uint ticketPrice, uint ticketPurchases) : base()
        {
            Time = time;
            TicketPrice = ticketPrice;
            TicketPurchases = ticketPurchases;
        }
        void SessionInterface.Modify(string time, uint ticketPrice, uint ticketPurchases)
        {
            this.Time = time;
            this.TicketPrice = ticketPrice;
            this.TicketPurchases = ticketPurchases;
        }
    }
    */
}

