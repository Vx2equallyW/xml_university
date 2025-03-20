namespace WinFormsXMLvalidation
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
            groupBox1 = new GroupBox();
            ButtonSelectXSD = new Button();
            ButtonSelectXML = new Button();
            xsdDocumentPath = new TextBox();
            label3 = new Label();
            xmlDocumentPath = new TextBox();
            label2 = new Label();
            nameSpaceInput = new TextBox();
            label1 = new Label();
            ButtonValidate = new Button();
            groupBox2 = new GroupBox();
            ListBoxResultOutput = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ButtonSelectXSD);
            groupBox1.Controls.Add(ButtonSelectXML);
            groupBox1.Controls.Add(xsdDocumentPath);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(xmlDocumentPath);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameSpaceInput);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 392);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выбор файлов";
            // 
            // ButtonSelectXSD
            // 
            ButtonSelectXSD.BackColor = Color.Transparent;
            ButtonSelectXSD.Location = new Point(345, 294);
            ButtonSelectXSD.Name = "ButtonSelectXSD";
            ButtonSelectXSD.Size = new Size(106, 27);
            ButtonSelectXSD.TabIndex = 7;
            ButtonSelectXSD.Text = "Обзор..";
            ButtonSelectXSD.UseVisualStyleBackColor = false;
            ButtonSelectXSD.Click += ButtonSelectXSD_Click;
            // 
            // ButtonSelectXML
            // 
            ButtonSelectXML.Location = new Point(345, 180);
            ButtonSelectXML.Name = "ButtonSelectXML";
            ButtonSelectXML.Size = new Size(106, 27);
            ButtonSelectXML.TabIndex = 6;
            ButtonSelectXML.Text = "Обзор..";
            ButtonSelectXML.UseVisualStyleBackColor = true;
            ButtonSelectXML.Click += ButtonSelectXML_Click;
            // 
            // xsdDocumentPath
            // 
            xsdDocumentPath.Location = new Point(24, 294);
            xsdDocumentPath.Name = "xsdDocumentPath";
            xsdDocumentPath.Size = new Size(275, 27);
            xsdDocumentPath.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 271);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 4;
            label3.Text = "XSD-документ:";
            // 
            // xmlDocumentPath
            // 
            xmlDocumentPath.Location = new Point(24, 180);
            xmlDocumentPath.Name = "xmlDocumentPath";
            xmlDocumentPath.Size = new Size(275, 27);
            xmlDocumentPath.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 157);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 2;
            label2.Text = "XML-документ:";
            // 
            // nameSpaceInput
            // 
            nameSpaceInput.Location = new Point(24, 75);
            nameSpaceInput.Name = "nameSpaceInput";
            nameSpaceInput.Size = new Size(489, 27);
            nameSpaceInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 52);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 0;
            label1.Text = "Пространство имен:";
            // 
            // ButtonValidate
            // 
            ButtonValidate.Location = new Point(134, 476);
            ButtonValidate.Name = "ButtonValidate";
            ButtonValidate.Size = new Size(323, 48);
            ButtonValidate.TabIndex = 1;
            ButtonValidate.Text = "Проверить";
            ButtonValidate.UseVisualStyleBackColor = true;
            ButtonValidate.Click += ButtonValidate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ListBoxResultOutput);
            groupBox2.Location = new Point(612, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(600, 392);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Результаты проверки";
            // 
            // ListBoxResultOutput
            // 
            ListBoxResultOutput.FormattingEnabled = true;
            ListBoxResultOutput.Location = new Point(6, 22);
            ListBoxResultOutput.Name = "ListBoxResultOutput";
            ListBoxResultOutput.Size = new Size(588, 364);
            ListBoxResultOutput.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 757);
            Controls.Add(groupBox2);
            Controls.Add(ButtonValidate);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Валидация XML-документа по XSD-схеме. Романов А. В. ИИб-233";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox nameSpaceInput;
        private Label label1;
        private Label label2;
        private TextBox xmlDocumentPath;
        private Label label3;
        private TextBox xsdDocumentPath;
        private Button ButtonSelectXML;
        private Button ButtonSelectXSD;
        private Button ButtonValidate;
        private GroupBox groupBox2;
        private ListBox ListBoxResultOutput;
        private OpenFileDialog openFileDialog1;
    }
}
