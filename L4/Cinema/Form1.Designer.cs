namespace Cinema
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
            listBoxFilms = new ListBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            AddFilmSession = new Button();
            AddMovie = new Button();
            listBoxFilmSessions = new ListBox();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewObjectParameters).BeginInit();
            SuspendLayout();
            // 
            // listBoxFilms
            // 
            listBoxFilms.FormattingEnabled = true;
            listBoxFilms.Location = new Point(6, 43);
            listBoxFilms.Name = "listBoxFilms";
            listBoxFilms.Size = new Size(366, 204);
            listBoxFilms.TabIndex = 0;
            listBoxFilms.SelectedIndexChanged += listBoxFilms_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(AddFilmSession);
            groupBox1.Controls.Add(AddMovie);
            groupBox1.Controls.Add(listBoxFilmSessions);
            groupBox1.Controls.Add(listBoxFilms);
            groupBox1.Location = new Point(6, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 293);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильмы и сеансы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 20);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 7;
            label2.Text = "Фильм";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(525, 20);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 6;
            label1.Text = "Сеансы фильма";
            // 
            // AddFilmSession
            // 
            AddFilmSession.Location = new Point(511, 253);
            AddFilmSession.Name = "AddFilmSession";
            AddFilmSession.Size = new Size(160, 29);
            AddFilmSession.TabIndex = 4;
            AddFilmSession.Text = "Добавить";
            AddFilmSession.UseVisualStyleBackColor = true;
            AddFilmSession.Click += AddFilmSession_Click;
            // 
            // AddMovie
            // 
            AddMovie.Location = new Point(111, 253);
            AddMovie.Name = "AddMovie";
            AddMovie.Size = new Size(160, 29);
            AddMovie.TabIndex = 2;
            AddMovie.Text = "Добавить";
            AddMovie.UseVisualStyleBackColor = true;
            AddMovie.Click += AddMovie_Click;
            // 
            // listBoxFilmSessions
            // 
            listBoxFilmSessions.FormattingEnabled = true;
            listBoxFilmSessions.Location = new Point(404, 43);
            listBoxFilmSessions.Name = "listBoxFilmSessions";
            listBoxFilmSessions.Size = new Size(366, 204);
            listBoxFilmSessions.TabIndex = 1;
            listBoxFilmSessions.SelectedIndexChanged += listBoxFilmSessions_SelectedIndexChanged;
            // 
            // CalculateProfits
            // 
            CalculateProfits.Location = new Point(12, 461);
            CalculateProfits.Name = "CalculateProfits";
            CalculateProfits.Size = new Size(366, 29);
            CalculateProfits.TabIndex = 6;
            CalculateProfits.Text = "Определить общую выручку";
            CalculateProfits.UseVisualStyleBackColor = true;
            CalculateProfits.Click += CalculateProfits_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewObjectParameters);
            groupBox2.Location = new Point(6, 505);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 191);
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
            dataGridViewObjectParameters.Size = new Size(764, 159);
            dataGridViewObjectParameters.TabIndex = 0;
            // 
            // ExportData
            // 
            ExportData.Location = new Point(23, 702);
            ExportData.Name = "ExportData";
            ExportData.Size = new Size(160, 29);
            ExportData.TabIndex = 8;
            ExportData.Text = "Экспортировать";
            ExportData.UseVisualStyleBackColor = true;
            ExportData.Click += ExportData_Click;
            // 
            // ImportData
            // 
            ImportData.Location = new Point(606, 702);
            ImportData.Name = "ImportData";
            ImportData.Size = new Size(160, 29);
            ImportData.TabIndex = 9;
            ImportData.Text = "Импортировать";
            ImportData.UseVisualStyleBackColor = true;
            ImportData.Click += ImportData_Click;
            // 
            // CalculateViewersAmount
            // 
            CalculateViewersAmount.Location = new Point(410, 461);
            CalculateViewersAmount.Name = "CalculateViewersAmount";
            CalculateViewersAmount.Size = new Size(366, 29);
            CalculateViewersAmount.TabIndex = 10;
            CalculateViewersAmount.Text = "Определить общее число зрителей";
            CalculateViewersAmount.UseVisualStyleBackColor = true;
            CalculateViewersAmount.Click += CalculateViewersAmount_Click;
            // 
            // AddCinema
            // 
            AddCinema.Location = new Point(12, 113);
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
            listBoxCinemas.Size = new Size(366, 64);
            listBoxCinemas.TabIndex = 13;
            listBoxCinemas.SelectedIndexChanged += listBoxCinemas_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 46);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(77, 20);
            label4.TabIndex = 14;
            label4.Text = "Название";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 83);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(51, 20);
            label5.TabIndex = 15;
            label5.Text = "Адрес";
            // 
            // textBoxCinemaName
            // 
            textBoxCinemaName.Location = new Point(506, 43);
            textBoxCinemaName.Name = "textBoxCinemaName";
            textBoxCinemaName.Size = new Size(270, 27);
            textBoxCinemaName.TabIndex = 16;
            // 
            // textBoxCinemaAdress
            // 
            textBoxCinemaAdress.Location = new Point(506, 80);
            textBoxCinemaAdress.Name = "textBoxCinemaAdress";
            textBoxCinemaAdress.Size = new Size(270, 27);
            textBoxCinemaAdress.TabIndex = 17;
            // 
            // ChangeCinemaInfo
            // 
            ChangeCinemaInfo.Location = new Point(410, 113);
            ChangeCinemaInfo.Name = "ChangeCinemaInfo";
            ChangeCinemaInfo.Size = new Size(366, 29);
            ChangeCinemaInfo.TabIndex = 18;
            ChangeCinemaInfo.Text = "Изменить";
            ChangeCinemaInfo.UseVisualStyleBackColor = true;
            ChangeCinemaInfo.Click += ChangeCinemaInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 742);
            Controls.Add(ChangeCinemaInfo);
            Controls.Add(textBoxCinemaAdress);
            Controls.Add(textBoxCinemaName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBoxCinemas);
            Controls.Add(label3);
            Controls.Add(AddCinema);
            Controls.Add(CalculateViewersAmount);
            Controls.Add(ImportData);
            Controls.Add(ExportData);
            Controls.Add(groupBox2);
            Controls.Add(CalculateProfits);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewObjectParameters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxFilms;
        private GroupBox groupBox1;
        private ListBox listBoxFilmSessions;
        private Button AddFilmSession;
        private Button AddMovie;
        private Button CalculateProfits;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
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
    }
}
