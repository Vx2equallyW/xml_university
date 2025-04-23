namespace Ser_de_XML
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
            listBoxBankContribution = new ListBox();
            groupBox1 = new GroupBox();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxPatronymic = new TextBox();
            textBoxAccountNumber = new TextBox();
            textBoxContributionDate = new TextBox();
            textBoxContributionAmount = new TextBox();
            textBoxPercentage = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            AddBankContribution = new Button();
            buttonDeleteBankContribution = new Button();
            buttonChangeBankContribution = new Button();
            buttonExport = new Button();
            buttonImport = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxBankContribution
            // 
            listBoxBankContribution.FormattingEnabled = true;
            listBoxBankContribution.Location = new Point(6, 26);
            listBoxBankContribution.Name = "listBoxBankContribution";
            listBoxBankContribution.Size = new Size(265, 324);
            listBoxBankContribution.TabIndex = 0;
            listBoxBankContribution.SelectedIndexChanged += listBoxBankContribution_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxBankContribution);
            groupBox1.Location = new Point(27, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 361);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список вкладов";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(529, 87);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(529, 140);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(125, 27);
            textBoxSurname.TabIndex = 3;
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Location = new Point(529, 193);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.Size = new Size(125, 27);
            textBoxPatronymic.TabIndex = 4;
            // 
            // textBoxAccountNumber
            // 
            textBoxAccountNumber.Location = new Point(342, 87);
            textBoxAccountNumber.Name = "textBoxAccountNumber";
            textBoxAccountNumber.Size = new Size(125, 27);
            textBoxAccountNumber.TabIndex = 5;
            // 
            // textBoxContributionDate
            // 
            textBoxContributionDate.Location = new Point(342, 140);
            textBoxContributionDate.Name = "textBoxContributionDate";
            textBoxContributionDate.Size = new Size(125, 27);
            textBoxContributionDate.TabIndex = 6;
            // 
            // textBoxContributionAmount
            // 
            textBoxContributionAmount.Location = new Point(342, 193);
            textBoxContributionAmount.Name = "textBoxContributionAmount";
            textBoxContributionAmount.Size = new Size(125, 27);
            textBoxContributionAmount.TabIndex = 7;
            // 
            // textBoxPercentage
            // 
            textBoxPercentage.Location = new Point(342, 246);
            textBoxPercentage.Name = "textBoxPercentage";
            textBoxPercentage.Size = new Size(125, 27);
            textBoxPercentage.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 64);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 9;
            label1.Text = "Номер счета";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 117);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 10;
            label2.Text = "Дата вклада";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 170);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 11;
            label3.Text = "Сумма";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 223);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 12;
            label4.Text = "Процент";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(529, 64);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 13;
            label5.Text = "Имя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(529, 117);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 14;
            label6.Text = "Фамилия";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(529, 170);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 15;
            label7.Text = "Отчество";
            // 
            // AddBankContribution
            // 
            AddBankContribution.Location = new Point(27, 409);
            AddBankContribution.Name = "AddBankContribution";
            AddBankContribution.Size = new Size(125, 29);
            AddBankContribution.TabIndex = 16;
            AddBankContribution.Text = "Добавить";
            AddBankContribution.UseVisualStyleBackColor = true;
            AddBankContribution.Click += AddBankContribution_Click;
            // 
            // buttonDeleteBankContribution
            // 
            buttonDeleteBankContribution.Location = new Point(179, 409);
            buttonDeleteBankContribution.Name = "buttonDeleteBankContribution";
            buttonDeleteBankContribution.Size = new Size(125, 29);
            buttonDeleteBankContribution.TabIndex = 17;
            buttonDeleteBankContribution.Text = "Удалить";
            buttonDeleteBankContribution.UseVisualStyleBackColor = true;
            buttonDeleteBankContribution.Click += buttonDeleteBankContribution_Click;
            // 
            // buttonChangeBankContribution
            // 
            buttonChangeBankContribution.Location = new Point(529, 246);
            buttonChangeBankContribution.Name = "buttonChangeBankContribution";
            buttonChangeBankContribution.Size = new Size(125, 29);
            buttonChangeBankContribution.TabIndex = 18;
            buttonChangeBankContribution.Text = "Изменить";
            buttonChangeBankContribution.UseVisualStyleBackColor = true;
            buttonChangeBankContribution.Click += buttonChangeBankContribution_Click;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(342, 366);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(125, 29);
            buttonExport.TabIndex = 19;
            buttonExport.Text = "Экспорт";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // buttonImport
            // 
            buttonImport.Location = new Point(529, 366);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(125, 29);
            buttonImport.TabIndex = 20;
            buttonImport.Text = "Импорт";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonImport);
            Controls.Add(buttonExport);
            Controls.Add(buttonChangeBankContribution);
            Controls.Add(buttonDeleteBankContribution);
            Controls.Add(AddBankContribution);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPercentage);
            Controls.Add(textBoxContributionAmount);
            Controls.Add(textBoxContributionDate);
            Controls.Add(textBoxAccountNumber);
            Controls.Add(textBoxPatronymic);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBankContribution;
        private GroupBox groupBox1;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxPatronymic;
        private TextBox textBoxAccountNumber;
        private TextBox textBoxContributionDate;
        private TextBox textBoxContributionAmount;
        private TextBox textBoxPercentage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button AddBankContribution;
        private Button buttonDeleteBankContribution;
        private Button buttonChangeBankContribution;
        private Button buttonExport;
        private Button buttonImport;
    }
}
