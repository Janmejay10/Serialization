using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SerializationAndXml
{
    class S3   // updating xml data(increasing age by +1
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("test-doc.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//users/user");
            foreach (XmlNode userNode in userNodes)
            {
                int age = int.Parse(userNode.Attributes["age"].Value);
                userNode.Attributes["age"].Value = (age + 1).ToString();
            }
            xmlDoc.Save("test-doc.xml");
        }
    }
}