using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CinemaN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CalculateProfits = new Button();
            groupBox2 = new GroupBox();
            dataGridViewObjectParameters = new DataGridView();
            ExportData = new Button();
            ImportData = new Button();
            CalculateViewersAmount = new Button();
            AddCinema = new Button();
            label3 = new Label();
            listBoxCinemas = new ListBox();
            label4 = new Label();
            label5 = new Label();
            textBoxCinemaName = new TextBox();
            textBoxCinemaAdress = new TextBox();
            ChangeCinemaInfo = new Button();
            listBoxFilms = new ListBox();
            listBoxFilmSessions = new ListBox();
            AddMovie = new Button();
            AddFilmSession = new Button();
            label1 = new Label();
            label2 = new Label();
            ChangeFilmInfo = new Button();
            textBoxFilmGenre = new TextBox();
            textBoxFilmName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ChangeFilmSessionInfo = new Button();
            textBoxFilmSessionTicketPrice = new TextBox();
            textBoxFilmSessionTime = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxFilmSessionTicketPurchases = new TextBox();
            label10 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewObjectParameters).BeginInit();
            SuspendLayout();
            // 
            // CalculateProfits
            // 
            CalculateProfits.Location = new Point(858, 421);
            CalculateProfits.Name = "CalculateProfits";
            CalculateProfits.Size = new Size(378, 29);
            CalculateProfits.TabIndex = 6;
            CalculateProfits.Text = "Определить общую выручку";
            CalculateProfits.UseVisualStyleBackColor = true;
            CalculateProfits.Click += CalculateProfits_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewObjectParameters);
            groupBox2.Location = new Point(852, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 375);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Параметры объекта";
            // 
            // dataGridViewObjectParameters
            // 
            dataGridViewObjectParameters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewObjectParameters.Location = new Point(6, 26);
            dataGridViewObjectParameters.Name = "dataGridViewObjectParameters";
            dataGridViewObjectParameters.RowHeadersWidth = 51;
            dataGridViewObjectParameters.Size = new Size(378, 343);
            dataGridViewObjectParameters.TabIndex = 0;
            // 
            // ExportData
            // 
            ExportData.Location = new Point(858, 583);
            ExportData.Name = "ExportData";
            ExportData.Size = new Size(160, 29);
            ExportData.TabIndex = 8;
            ExportData.Text = "Экспортировать";
            ExportData.UseVisualStyleBackColor = true;
            ExportData.Click += ExportData_Click;
            // 
            // ImportData
            // 
            ImportData.Location = new Point(1076, 583);
            ImportData.Name = "ImportData";
            ImportData.Size = new Size(160, 29);
            ImportData.TabIndex = 9;
            ImportData.Text = "Импортировать";
            ImportData.UseVisualStyleBackColor = true;
            ImportData.Click += ImportData_Click;
            // 
            // CalculateViewersAmount
            // 
            CalculateViewersAmount.Location = new Point(858, 472);
            CalculateViewersAmount.Name = "CalculateViewersAmount";
            CalculateViewersAmount.Size = new Size(378, 29);
            CalculateViewersAmount.TabIndex = 10;
            CalculateViewersAmount.Text = "Определить общее число зрителей";
            CalculateViewersAmount.UseVisualStyleBackColor = true;
            CalculateViewersAmount.Click += CalculateViewersAmount_Click;
            // 
            // AddCinema
            // 
            AddCinema.Location = new Point(12, 173);
            AddCinema.Name = "AddCinema";
            AddCinema.Size = new Size(366, 29);
            AddCinema.TabIndex = 11;
            AddCinema.Text = "Добавить кинотеатр";
            AddCinema.UseVisualStyleBackColor = true;
            AddCinema.Click += AddCinema_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 20);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 12;
            label3.Text = "Кинотеатры";
            // 
            // listBoxCinemas
            // 
            listBoxCinemas.FormattingEnabled = true;
            listBoxCinemas.Location = new Point(12, 43);
            listBoxCinemas.Name = "listBoxCinemas";
            listBoxCinemas.Size = new Size(366, 124);
            listBoxCinemas.TabIndex = 13;
            listBoxCinemas.SelectedIndexChanged += listBoxCinemas_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 78);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(77, 20);
            label4.TabIndex = 14;
            label4.Text = "Название";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 111);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(51, 20);
            label5.TabIndex = 15;
            label5.Text = "Адрес";
            // 
            // textBoxCinemaName
            // 
            textBoxCinemaName.Location = new Point(506, 75);
            textBoxCinemaName.Name = "textBoxCinemaName";
            textBoxCinemaName.Size = new Size(270, 27);
            textBoxCinemaName.TabIndex = 16;
            // 
            // textBoxCinemaAdress
            // 
            textBoxCinemaAdress.Location = new Point(506, 108);
            textBoxCinemaAdress.Name = "textBoxCinemaAdress";
            textBoxCinemaAdress.Size = new Size(270, 27);
            textBoxCinemaAdress.TabIndex = 17;
            // 
            // ChangeCinemaInfo
            // 
            ChangeCinemaInfo.Location = new Point(410, 173);
            ChangeCinemaInfo.Name = "ChangeCinemaInfo";
            ChangeCinemaInfo.Size = new Size(366, 29);
            ChangeCinemaInfo.TabIndex = 18;
            ChangeCinemaInfo.Text = "Изменить";
            ChangeCinemaInfo.UseVisualStyleBackColor = true;
            ChangeCinemaInfo.Click += ChangeCinemaInfo_Click;
            // 
            // listBoxFilms
            // 
            listBoxFilms.FormattingEnabled = true;
            listBoxFilms.Location = new Point(12, 242);
            listBoxFilms.Name = "listBoxFilms";
            listBoxFilms.Size = new Size(366, 124);
            listBoxFilms.TabIndex = 0;
            listBoxFilms.SelectedIndexChanged += listBoxFilms_SelectedIndexChanged;
            // 
            // listBoxFilmSessions
            // 
            listBoxFilmSessions.FormattingEnabled = true;
            listBoxFilmSessions.Location = new Point(12, 453);
            listBoxFilmSessions.Name = "listBoxFilmSessions";
            listBoxFilmSessions.Size = new Size(366, 124);
            listBoxFilmSessions.TabIndex = 1;
            listBoxFilmSessions.SelectedIndexChanged += listBoxFilmSessions_SelectedIndexChanged;
            // 
            // AddMovie
            // 
            AddMovie.Location = new Point(12, 372);
            AddMovie.Name = "AddMovie";
            AddMovie.Size = new Size(366, 29);
            AddMovie.TabIndex = 2;
            AddMovie.Text = "Добавить фильм";
            AddMovie.UseVisualStyleBackColor = true;
            AddMovie.Click += AddMovie_Click;
            // 
            // AddFilmSession
            // 
            AddFilmSession.Location = new Point(12, 583);
            AddFilmSession.Name = "AddFilmSession";
            AddFilmSession.Size = new Size(366, 29);
            AddFilmSession.TabIndex = 4;
            AddFilmSession.Text = "Добавить сеанс";
            AddFilmSession.UseVisualStyleBackColor = true;
            AddFilmSession.Click += AddFilmSession_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 430);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 6;
            label1.Text = "Сеансы фильма";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 219);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 7;
            label2.Text = "Фильмы";
            // 
            // ChangeFilmInfo
            // 
            ChangeFilmInfo.Location = new Point(410, 372);
            ChangeFilmInfo.Name = "ChangeFilmInfo";
            ChangeFilmInfo.Size = new Size(366, 29);
            ChangeFilmInfo.TabIndex = 23;
            ChangeFilmInfo.Text = "Изменить";
            ChangeFilmInfo.UseVisualStyleBackColor = true;
            ChangeFilmInfo.Click += ChangeFilmInfo_Click;
            // 
            // textBoxFilmGenre
            // 
            textBoxFilmGenre.Location = new Point(506, 311);
            textBoxFilmGenre.Name = "textBoxFilmGenre";
            textBoxFilmGenre.Size = new Size(270, 27);
            textBoxFilmGenre.TabIndex = 22;
            // 
            // textBoxFilmName
            // 
            textBoxFilmName.Location = new Point(506, 278);
            textBoxFilmName.Name = "textBoxFilmName";
            textBoxFilmName.Size = new Size(270, 27);
            textBoxFilmName.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(410, 314);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(48, 20);
            label6.TabIndex = 20;
            label6.Text = "Жанр";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(410, 281);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(77, 20);
            label7.TabIndex = 19;
            label7.Text = "Название";
            // 
            // ChangeFilmSessionInfo
            // 
            ChangeFilmSessionInfo.Location = new Point(410, 583);
            ChangeFilmSessionInfo.Name = "ChangeFilmSessionInfo";
            ChangeFilmSessionInfo.Size = new Size(366, 29);
            ChangeFilmSessionInfo.TabIndex = 28;
            ChangeFilmSessionInfo.Text = "Изменить";
            ChangeFilmSessionInfo.UseVisualStyleBackColor = true;
            ChangeFilmSessionInfo.Click += ChangeFilmSessionInfo_Click;
            // 
            // textBoxFilmSessionTicketPrice
            // 
            textBoxFilmSessionTicketPrice.Location = new Point(538, 502);
            textBoxFilmSessionTicketPrice.Name = "textBoxFilmSessionTicketPrice";
            textBoxFilmSessionTicketPrice.Size = new Size(238, 27);
            textBoxFilmSessionTicketPrice.TabIndex = 27;
            // 
            // textBoxFilmSessionTime
            // 
            textBoxFilmSessionTime.Location = new Point(506, 469);
            textBoxFilmSessionTime.Name = "textBoxFilmSessionTime";
            textBoxFilmSessionTime.Size = new Size(270, 27);
            textBoxFilmSessionTime.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(410, 505);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(97, 20);
            label8.TabIndex = 25;
            label8.Text = "Цена билета";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(410, 472);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(54, 20);
            label9.TabIndex = 24;
            label9.Text = "Время";
            // 
            // textBoxFilmSessionTicketPurchases
            // 
            textBoxFilmSessionTicketPurchases.Location = new Point(588, 535);
            textBoxFilmSessionTicketPurchases.Name = "textBoxFilmSessionTicketPurchases";
            textBoxFilmSessionTicketPurchases.Size = new Size(188, 27);
            textBoxFilmSessionTicketPurchases.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(410, 538);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(158, 20);
            label10.TabIndex = 29;
            label10.Text = "Количество зрителей";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 631);
            Controls.Add(textBoxFilmSessionTicketPurchases);
            Controls.Add(label10);
            Controls.Add(ChangeFilmSessionInfo);
            Controls.Add(textBoxFilmSessionTicketPrice);
            Controls.Add(textBoxFilmSessionTime);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(ChangeFilmInfo);
            Controls.Add(textBoxFilmGenre);
            Controls.Add(textBoxFilmName);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(ChangeCinemaInfo);
            Controls.Add(AddMovie);
            Controls.Add(label1);
            Controls.Add(listBoxFilms);
            Controls.Add(textBoxCinemaAdress);
            Controls.Add(AddFilmSession);
            Controls.Add(textBoxCinemaName);
            Controls.Add(label5);
            Controls.Add(listBoxFilmSessions);
            Controls.Add(label4);
            Controls.Add(listBoxCinemas);
            Controls.Add(label3);
            Controls.Add(AddCinema);
            Controls.Add(CalculateViewersAmount);
            Controls.Add(ImportData);
            Controls.Add(ExportData);
            Controls.Add(groupBox2);
            Controls.Add(CalculateProfits);
            Name = "Form1";
            Text = "Панель учёта кинотеатров";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewObjectParameters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CalculateProfits;
        private GroupBox groupBox2;
        private DataGridView dataGridViewObjectParameters;
        private Button ExportData;
        private Button ImportData;
        private Button CalculateViewersAmount;
        private Button AddCinema;
        private Label label3;
        private ListBox listBoxCinemas;
        private Label label4;
        private Label label5;
        private TextBox textBoxCinemaName;
        private TextBox textBoxCinemaAdress;
        private Button ChangeCinemaInfo;
        private ListBox listBoxFilms;
        private ListBox listBoxFilmSessions;
        private Button AddMovie;
        private Button AddFilmSession;
        private Label label1;
        private Label label2;
        private Button ChangeFilmInfo;
        private TextBox textBoxFilmGenre;
        private TextBox textBoxFilmName;
        private Label label6;
        private Label label7;
        private Button ChangeFilmSessionInfo;
        private TextBox textBoxFilmSessionTicketPrice;
        private TextBox textBoxFilmSessionTime;
        private Label label8;
        private Label label9;
        private TextBox textBoxFilmSessionTicketPurchases;
        private Label label10;
    }
}