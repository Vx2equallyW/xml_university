using BankContributionClasses;
namespace Ser_de_XML
{
    public partial class Form1 : Form
    {
        List<BankContribution> bankContributions;
        string xmlUri;

        public Form1()
        {
            InitializeComponent();
            bankContributions = new List<BankContribution>();

            xmlUri = @"bankContributions";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RefreshListBoxBankContributions()
        {
            listBoxBankContribution.Items.Clear();
            int i = 0;

            foreach (BankContribution contribution in bankContributions)
            {
                listBoxBankContribution.Items.Add(string.Format("{0}. {1}",
                    ++i, contribution.AccountNumber));
            }
        }

        private void AddBankContribution_Click(object sender, EventArgs e)
        {
            BankContribution newBankContribution =
                new BankContribution(
                    uint.Parse(textBoxAccountNumber.Text),
                    new Contributor(
                        textBoxName.Text,
                        textBoxSurname.Text,
                        textBoxPatronymic.Text
                    ),
                    textBoxContributionDate.Text,
                    uint.Parse(textBoxContributionAmount.Text),
                    uint.Parse(textBoxPercentage.Text)
                );
            bankContributions.Add(newBankContribution);
            RefreshListBoxBankContributions();
        }

        private void buttonDeleteBankContribution_Click(object sender, EventArgs e)
        {
            int index = listBoxBankContribution.SelectedIndex;
            if (index >= 0 && index < bankContributions.Count)
            {
                bankContributions.RemoveAt(index);
            }
            RefreshListBoxBankContributions();
        }


        private void listBoxBankContribution_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxBankContribution.SelectedIndex;
            if (index >= 0 && index < bankContributions.Count)
            {
                textBoxName.Text = bankContributions[index].Contributor.Name;
                textBoxSurname.Text = bankContributions[index].Contributor.Surname;
                textBoxPatronymic.Text = bankContributions[index].Contributor.Patronymic;
                textBoxAccountNumber.Text = bankContributions[index].AccountNumber.ToString();
                textBoxContributionDate.Text = bankContributions[index].ContributionDate.ToString();
                textBoxContributionAmount.Text = bankContributions[index].ContributionAmount.ToString();
                textBoxPercentage.Text = bankContributions[index].Precentage.ToString();
            }
        }

        private void buttonChangeBankContribution_Click(object sender, EventArgs e)
        {
            int index = listBoxBankContribution.SelectedIndex;
            if (index >= 0 && index < bankContributions.Count)
            {
                bankContributions[index].Contributor.Name = textBoxName.Text;
                bankContributions[index].Contributor.Surname = textBoxSurname.Text;
                bankContributions[index].Contributor.Patronymic = textBoxPatronymic.Text;
                bankContributions[index].AccountNumber = uint.Parse(textBoxAccountNumber.Text);
                bankContributions[index].ContributionDate = textBoxContributionDate.Text;
                bankContributions[index].ContributionAmount = uint.Parse(textBoxContributionAmount.Text);
                bankContributions[index].Precentage = uint.Parse(textBoxPercentage.Text);
            }
            RefreshListBoxBankContributions();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            XmlDataProvider<List<BankContribution>>.SaveObject(xmlUri, bankContributions);
            MessageBox.Show("Данные успешно сохранены!");
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            bankContributions = XmlDataProvider<List<BankContribution>>.LoadObject(xmlUri);
            RefreshListBoxBankContributions();
            MessageBox.Show("Данные успешно загружены!");
        }
    }
}
