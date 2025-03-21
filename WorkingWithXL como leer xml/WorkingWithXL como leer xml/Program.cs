using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string path = "archivo.xml";
        UsingXmlReader(path);
        UsingXmlDocument(path);
        UsingXPath(path);
    }

    static void UsingXmlReader(string path)
    {
        using XmlReader xmlReader = XmlReader.Create(path);
        while (xmlReader.Read())
        {
            if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "project")
            {
                if (xmlReader.HasAttributes)
                {
                    Console.WriteLine(xmlReader.GetAttribute("name"));
                    Console.WriteLine(xmlReader.GetAttribute("launch"));
                }
            }
        }
    }

    static void UsingXmlDocument(string path)
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(path);
        foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes[0].ChildNodes)
        {
            Console.WriteLine(node.Attributes["name"].Value);
            Console.WriteLine(node.Attributes["launch"].Value);
            foreach (XmlNode edition in node.FirstChild.ChildNodes)
            {
                Console.WriteLine(edition.Attributes["language"].Value);
            }
        }
    }

    static void UsingXPath(string path)
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(path);
        XmlNodeList projects = xmlDoc.SelectNodes("//wikimedia/projects/project");
        foreach (XmlNode node in projects)
        {
            Console.WriteLine(node.Attributes["name"].Value);
            Console.WriteLine(node.Attributes["launch"].Value);
            XmlNode edition = node.SelectSingleNode("editions");
            foreach (XmlNode lang in edition.ChildNodes)
            {
                Console.WriteLine(lang.Attributes["language"].Value);
            }
        }
    }
}
