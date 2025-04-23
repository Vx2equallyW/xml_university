using System.Xml;
using System.Xml.Schema;

namespace WinFormsXMLvalidation
{
    public partial class Form1 : Form
    {
        bool xmlIsValid = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void ReaderValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Warning)
            {
                ListBoxResultOutput.Items.Add("Предупреждение: " + e.Message);
                xmlIsValid = false;
            }
            else if (e.Severity == XmlSeverityType.Error)
            {
                ListBoxResultOutput.Items.Add("Ошибка: " + e.Message);
                xmlIsValid = false;
            }
        }

        private void ButtonSelectXML_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML-файлы (*.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xmlDocumentPath.Text = openFileDialog1.FileName;
            }
        }

        private void ButtonSelectXSD_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML-файлы (*.xsd)|*.xsd";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xsdDocumentPath.Text = openFileDialog1.FileName;
            }
        }

        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            ListBoxResultOutput.Items.Clear();
            XmlReaderSettings rdSets = new XmlReaderSettings();
            rdSets.ValidationType = ValidationType.Schema;
            var schema = rdSets.Schemas.Add(nameSpaceInput.Text, xsdDocumentPath.Text);
            rdSets.ValidationEventHandler += new ValidationEventHandler(ReaderValidationEventHandler);
            XmlReader reader = XmlReader.Create(xmlDocumentPath.Text, rdSets);
            while (reader.Read()) ;
            if (xmlIsValid == true)
            {
                ListBoxResultOutput.Items.Add("Ошибок не обнаружено! XML-документ соответсвтвует схеме.");
            }
            rdSets.Schemas.Remove(schema);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameSpaceInput.Text = "https://github.com/Vx2equallyW";
        }
    }
}
