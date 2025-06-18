using System.Xml;
using System.Xml.Serialization;

namespace BankContributionClasses
{
    [Serializable]
    public class BankContribution
    {
        [XmlAttribute]
        public uint AccountNumber { get; set; }
        public Contributor Contributor { get; set; }
        public string ContributionDate { get; set; }
        public uint ContributionAmount { get; set; }
        public uint Precentage { get; set; }

        public BankContribution() { }
        public BankContribution(uint accountNumber, Contributor contributor, string contributionDate, uint contributionAmount, uint precentage)
        {
            AccountNumber = accountNumber;
            Contributor = contributor;
            ContributionDate = contributionDate;
            ContributionAmount = contributionAmount;
            Precentage = precentage;
        }
    }
    
    
    [Serializable]
    public class Contributor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public Contributor() { }

        public Contributor(string name, string surname, string patronymic)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
        }
    }
    public static class XmlDataProvider<T>
            where T : class, new()
    {
            static XmlSerializer xmlSer = new XmlSerializer(typeof(T));
            public static void SaveObject(string uri, T obj)
            {
                XmlWriterSettings xmlWrS = new XmlWriterSettings();
                xmlWrS.Indent = true;
                XmlWriter xmlWrt = XmlWriter.Create(uri, xmlWrS);
                xmlSer.Serialize(xmlWrt, obj);
                xmlWrt.Close();
            }

            public static T LoadObject(string uri)
            {
                XmlReaderSettings xmlRdS = new XmlReaderSettings();
                XmlReader xmlRdr = XmlReader.Create(uri, xmlRdS);
                T obj = xmlSer.Deserialize(xmlRdr) as T;
                xmlRdr.Close();
                return obj;
            }

    }
}
