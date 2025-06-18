using EssentialClasses;
using System;
namespace CinemaN
{
    public partial class Form1 : Form
    {
        List<AdapterCinema> cinemas = new List<AdapterCinema>();
        string xmlUri = @"Cinemas";

        public Form1()
        {
            InitializeComponent();
            //Change Display Members of listboxes.
            listBoxCinemas.DisplayMember = "CinemaName";
            listBoxFilms.DisplayMember = "Name";
            listBoxFilmSessions.DisplayMember = "Time";
        }

        private void RefreshCinemaBox()
        {
            listBoxCinemas.Items.Clear();
            listBoxFilms.Items.Clear();
            listBoxFilmSessions.Items.Clear();
            foreach (AdapterCinema cinema in cinemas)
            {
                listBoxCinemas.Items.Add(cinema);
            }
            RefreshFilmsBox();
        }

        private void RefreshFilmsBox()
        {
            listBoxFilms.Items.Clear();
            listBoxFilmSessions.Items.Clear();
            if (listBoxCinemas.SelectedItem != null)
            {
                AdapterCinema selectedCinema = (AdapterCinema)listBoxCinemas.SelectedItem;
                foreach (Film film in selectedCinema.Films)
                {
                    listBoxFilms.Items.Add(film);
                }
            }
            RefreshFilmSessionsBox();
        }
        private void RefreshFilmSessionsBox()
        {
            listBoxFilmSessions.Items.Clear();
            if (listBoxFilms.SelectedItem != null)
            {
                Film selectedFilm = (Film)listBoxFilms.SelectedItem;
                foreach (Session session in selectedFilm.Sessions)
                {
                    listBoxFilmSessions.Items.Add(session);
                }
            }
        }

        private void AddCinema_Click(object sender, EventArgs e)
        {
            string newCinemaName = textBoxCinemaName.Text;
            string newCinemaAdress = textBoxCinemaAdress.Text;
            AdapterCinema newCinema = new AdapterCinema(newCinemaName, newCinemaAdress);
            cinemas.Add(newCinema);
            //Refresh
            RefreshCinemaBox();
        }

        private void ChangeCinemaInfo_Click(object sender, EventArgs e)
        {
            if (listBoxCinemas.SelectedItem != null)
            {
                AdapterCinema cinema = (AdapterCinema)listBoxCinemas.SelectedItem;

                string newCinemaName = textBoxCinemaName.Text;
                string newCinemaAdress = textBoxCinemaAdress.Text;

                cinema.ModifyCinemaInfo(newCinemaName, newCinemaAdress);
                //Refresh
                RefreshCinemaBox();
            }
        }

        private void listBoxCinemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show info on datagrid.
            dataGridViewObjectParameters.Columns.Clear();
            dataGridViewObjectParameters.Rows.Clear();
            dataGridViewObjectParameters.Columns.Add("Value", "Значение");
            dataGridViewObjectParameters.Rows.Add(2);
            if (listBoxCinemas.SelectedItem != null)
            {
                AdapterCinema cinema = (AdapterCinema)listBoxCinemas.SelectedItem;
                // Header
                dataGridViewObjectParameters.Rows[0].HeaderCell.Value = "Название";
                dataGridViewObjectParameters.Rows[1].HeaderCell.Value = "Адрес";
                // Data
                dataGridViewObjectParameters.Rows[0].Cells[0].Value = cinema.CinemaName;
                dataGridViewObjectParameters.Rows[1].Cells[0].Value = cinema.CinemaAdress;
            }
            //Refresh
            RefreshFilmsBox();
        }

        private void AddMovie_Click(object sender, EventArgs e)
        {
            if (listBoxCinemas.SelectedItem != null)
            {
                AdapterCinema cinema = (AdapterCinema)listBoxCinemas.SelectedItem;

                string newFilmName = textBoxFilmName.Text;
                string newFilmGenre = textBoxFilmGenre.Text;

                Film newFilm = new Film();

                newFilm.Name = newFilmName;
                newFilm.Genre = newFilmGenre;

                cinema.AddFilmToCinema(newFilm);
            }
            //Refresh
            RefreshFilmsBox();
        }

        private void ChangeFilmInfo_Click(object sender, EventArgs e)
        {
            if (listBoxFilms.SelectedItem != null && listBoxCinemas.SelectedItem != null)
            {
                Film film = (Film)listBoxFilms.SelectedItem;

                string newFilmName = textBoxFilmName.Text;
                string newFilmGenre = textBoxFilmGenre.Text;

                AdapterCinema.ModifyFilmInfo(film, newFilmName, newFilmGenre);
                //Refresh
                RefreshFilmsBox();
            }
        }

        private void listBoxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show info on datagrid.
            dataGridViewObjectParameters.Columns.Clear();
            dataGridViewObjectParameters.Rows.Clear();
            dataGridViewObjectParameters.Columns.Add("Value", "Значение");
            dataGridViewObjectParameters.Rows.Add(2);
            if (listBoxFilms.SelectedItem != null)
            {
                Film film = (Film)listBoxFilms.SelectedItem;
                // Header
                dataGridViewObjectParameters.Rows[0].HeaderCell.Value = "Название";
                dataGridViewObjectParameters.Rows[1].HeaderCell.Value = "Жанр";
                // Data
                dataGridViewObjectParameters.Rows[0].Cells[0].Value = film.Name;
                dataGridViewObjectParameters.Rows[1].Cells[0].Value = film.Genre;
            }
            //Refresh
            RefreshFilmSessionsBox();

        }

        private void AddFilmSession_Click(object sender, EventArgs e)
        {
            if (listBoxFilms.SelectedItem != null)
            {
                Film film = (Film)listBoxFilms.SelectedItem;

                string newSessionTime = textBoxFilmSessionTime.Text;
                uint newTicketPrice = uint.Parse(textBoxFilmSessionTicketPrice.Text);
                uint newTicketPurchases = uint.Parse(textBoxFilmSessionTicketPurchases.Text);

                Session newSession = new Session();

                newSession.Time = newSessionTime;
                newSession.TicketPrice = newTicketPrice;
                newSession.TicketPurchases = newTicketPurchases;

                AdapterCinema.AddSessionToFilm(film, newSession);
            }
            //Refresh
            RefreshFilmSessionsBox();
        }

        private void ChangeFilmSessionInfo_Click(object sender, EventArgs e)
        {
            if (listBoxFilmSessions.SelectedItem != null && listBoxFilms.SelectedItem != null)
            {
                Session session = (Session)listBoxFilmSessions.SelectedItem;

                string newSessionTime = textBoxFilmSessionTime.Text;
                uint newTicketPrice = uint.Parse(textBoxFilmSessionTicketPrice.Text);
                uint newTicketPurchases = uint.Parse(textBoxFilmSessionTicketPurchases.Text);

                AdapterCinema.ModifyFilmSessionInfo(session, newSessionTime, newTicketPrice, newTicketPurchases);
                //Refresh
                RefreshFilmSessionsBox();
            }
        }

        private void listBoxFilmSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show info on datagrid.
            dataGridViewObjectParameters.Columns.Clear();
            dataGridViewObjectParameters.Rows.Clear();
            dataGridViewObjectParameters.Columns.Add("Value", "Значение");
            dataGridViewObjectParameters.Rows.Add(3);
            if (listBoxFilmSessions.SelectedItem != null)
            {
                Session session = (Session)listBoxFilmSessions.SelectedItem;
                // Header
                dataGridViewObjectParameters.Rows[0].HeaderCell.Value = "Время";
                dataGridViewObjectParameters.Rows[1].HeaderCell.Value = "Стоимость билета";
                dataGridViewObjectParameters.Rows[2].HeaderCell.Value = "Количество зрителей";
                // Data
                dataGridViewObjectParameters.Rows[0].Cells[0].Value = session.Time;
                dataGridViewObjectParameters.Rows[1].Cells[0].Value = session.TicketPrice;
                dataGridViewObjectParameters.Rows[2].Cells[0].Value = session.TicketPurchases;
            }
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
            foreach (AdapterCinema cinema in cinemas)
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
            XmlDataProvider<List<AdapterCinema>>.SaveObject(xmlUri, cinemas);
            MessageBox.Show("Данные успешно сохранены!");
        }

        private void ImportData_Click(object sender, EventArgs e)
        {
            cinemas = XmlDataProvider<List<AdapterCinema>>.LoadObject(xmlUri);
            RefreshCinemaBox();
            MessageBox.Show("Данные успешно загружены!");
        }

    }

}

