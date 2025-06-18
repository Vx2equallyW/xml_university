using ClassLibrary;
namespace Cinema
{
    public partial class Form1 : Form
    {
        List<CinemaBuilding> cinemas;
        string xmlUri;

        public Form1()
        {
            InitializeComponent();
            cinemas = new List<CinemaBuilding>();
            dataGridViewObjectParameters.Columns.Add("Значение", "Значение");
            xmlUri = @"Cinemas";
        }

        private void RefreshListBoxCinemas()
        {
            listBoxCinemas.Items.Clear();
            int i = 0;

            foreach (CinemaBuilding cinema in cinemas)
            {
                listBoxCinemas.Items.Add(string.Format(
                    "{0}. {1}", ++i, cinema.CinemaName));
            }
        }
        private void RefreshListBoxFilms(int cinemaIndex)
        {
            listBoxFilms.Items.Clear();
            listBoxFilms.DisplayMember = "Name";

            foreach (Film film in cinemas[cinemaIndex].Films)
            {
                listBoxFilms.Items.Add(film);
            }
        }

        private void AddCinema_Click(object sender, EventArgs e)
        {
            CinemaBuilding cinema = new CinemaBuilding();
            cinema.CinemaName = textBoxCinemaName.Text;
            cinema.CinemaAdress = textBoxCinemaAdress.Text;
            cinema.Films = new List<Film>();
            cinemas.Add(cinema);
            RefreshListBoxCinemas();
        }

        private void ChangeCinemaInfo_Click(object sender, EventArgs e)
        {
            int index = listBoxCinemas.SelectedIndex;
            if (index >= 0 && index < cinemas.Count)
            {
                cinemas[index].CinemaName = textBoxCinemaName.Text;
                cinemas[index].CinemaAdress = textBoxCinemaAdress.Text;
                RefreshListBoxCinemas();
            }
        }

        private void listBoxCinemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxCinemas.SelectedIndex;
            if (index >= 0 && index < cinemas.Count)
            {
                textBoxCinemaName.Text = cinemas[index].CinemaName;
                textBoxCinemaAdress.Text = cinemas[index].CinemaAdress;
                RefreshListBoxFilms(index);
                listBoxFilmSessions.Items.Clear();
                dataGridViewObjectParameters.Rows.Clear();

                dataGridViewObjectParameters.Rows.Add(6);

                dataGridViewObjectParameters.Rows[0].HeaderCell.Value = "Название";
                dataGridViewObjectParameters.Rows[1].HeaderCell.Value = "Жанр";
            }
        }

        private void AddMovie_Click(object sender, EventArgs e)
        {
            Film newFilm = new Film();
            if (dataGridViewObjectParameters.Rows[0].Cells[0].Value != null)
            {
                newFilm.Name = (string)dataGridViewObjectParameters.Rows[0].Cells[0].Value;
            }
            else
            {
                newFilm.Name = "None";
            }
            if (dataGridViewObjectParameters.Rows[1].Cells[0].Value != null)
            {
                newFilm.Genre = (string)dataGridViewObjectParameters.Rows[1].Cells[0].Value;
            }
            else
            {
                newFilm.Genre = "None";
            }
            newFilm.Sessions = new List<Session>();
            int index = listBoxCinemas.SelectedIndex;
            if (index >= 0 && index < cinemas.Count)
            {
                cinemas[index].Films.Add(newFilm);
                RefreshListBoxFilms(index);
            }
        }

        private void ShowFilmParameters()
        {
            Film film = listBoxFilms.SelectedItem as Film;
            if (film != null)
            {
                dataGridViewObjectParameters.Rows[0].Cells[0].Value = film.Name;
                dataGridViewObjectParameters.Rows[1].Cells[0].Value = film.Genre;
            }

        }

        //Change data after changing selection?
        // Adding only
        // Show Cells for data creation according to selected object
        // Parent(selected) -> child(add)
        // CinemaBuilding(selected) -> Film(add)
        // *show parameters for film*
        private void RefreshFilmSessions()
        {
            Film film = listBoxFilms.SelectedItem as Film;
            listBoxFilmSessions.Items.Clear();
            listBoxFilmSessions.DisplayMember = "Time";
            if (film != null)
            {
                foreach (Session session in film.Sessions)
                {
                    listBoxFilmSessions.Items.Add(session);
                }

            }

        }

        private void listBoxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFilmParameters();
            RefreshFilmSessions();
            dataGridViewObjectParameters.Rows[2].HeaderCell.Value = "----Сеанс---";
            dataGridViewObjectParameters.Rows[3].HeaderCell.Value = "Время";
            dataGridViewObjectParameters.Rows[4].HeaderCell.Value = "Цена билета";
            dataGridViewObjectParameters.Rows[5].HeaderCell.Value = "Количество зрителей";
            dataGridViewObjectParameters.Rows[3].Cells[0].Value = "";
            dataGridViewObjectParameters.Rows[4].Cells[0].Value = "";
            dataGridViewObjectParameters.Rows[5].Cells[0].Value = "";
        }

        private void AddFilmSession_Click(object sender, EventArgs e)
        {
            Film film = listBoxFilms.SelectedItem as Film;

            if (film == null)
            {
                return;
            }

            Session newSession = new Session();

            if (dataGridViewObjectParameters.Rows[3].Cells[0].Value != null)
            {
                newSession.Time = (string)dataGridViewObjectParameters.Rows[3].Cells[0].Value;
            }
            else
            {
                newSession.Time = "None";
            }
            if (dataGridViewObjectParameters.Rows[4].Cells[0].Value != null)
            {
                newSession.TicketPrice = uint.Parse((string)dataGridViewObjectParameters.Rows[4].Cells[0].Value);
            }
            else
            {
                newSession.TicketPrice = 0;
            }
            if (dataGridViewObjectParameters.Rows[5].Cells[0].Value != null)
            {
                newSession.TicketPurchases = uint.Parse((string)dataGridViewObjectParameters.Rows[5].Cells[0].Value);
            }
            else
            {
                newSession.TicketPurchases = 0;
            }
            film.Sessions.Add(newSession);
            RefreshFilmSessions();
            dataGridViewObjectParameters.Rows[3].Cells[0].Value = "";
            dataGridViewObjectParameters.Rows[4].Cells[0].Value = "";
            dataGridViewObjectParameters.Rows[5].Cells[0].Value = "";
        }

        private void ShowFilmSessionInfo()
        {
            Session session = listBoxFilmSessions.SelectedItem as Session;
            if (session != null)
            {
                dataGridViewObjectParameters.Rows[3].Cells[0].Value = session.Time;
                dataGridViewObjectParameters.Rows[4].Cells[0].Value = session.TicketPrice;
                dataGridViewObjectParameters.Rows[5].Cells[0].Value = session.TicketPurchases;
            }
        }

        private void listBoxFilmSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFilmSessionInfo();
        }

        private void CalculateProfits_Click(object sender, EventArgs e)
        {
            uint profits = 0;
            foreach (CinemaBuilding cinema in cinemas)
            {
                foreach (Film film in cinema.Films)
                {
                    foreach (Session session in film.Sessions)
                    {
                        profits += session.TicketPrice * session.TicketPurchases;
                    }
                }
            }
            MessageBox.Show($"Общая выручка: {profits}", "Общая выручка");
        }

        private void CalculateViewersAmount_Click(object sender, EventArgs e)
        {
            uint tickets = 0;
            foreach (CinemaBuilding cinema in cinemas)
            {
                foreach (Film film in cinema.Films)
                {
                    foreach (Session session in film.Sessions)
                    {
                        tickets += session.TicketPurchases;
                    }
                }
            }
            MessageBox.Show($"Общее число зрителей: {tickets}", "Общее число зрителей");

        }

        private void ExportData_Click(object sender, EventArgs e)
        {
            XmlDataProvider<List<CinemaBuilding>>.SaveObject(xmlUri, cinemas);
            MessageBox.Show("Данные успешно сохранены!");
        }

        private void ImportData_Click(object sender, EventArgs e)
        {
            cinemas = XmlDataProvider<List<CinemaBuilding>>.LoadObject(xmlUri);
            MessageBox.Show("Данные успешно загружены!");
        }
    }
}
