using System;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string path = "archivo.xml";
        XElement storeXml = XElement.Load(path);

        var beers = from b in storeXml.Element("beers").Elements("beer")
                    orderby (string)b.Attribute("style")
                    select new Beer
                    {
                        Name = (string)b.Value,
                        Style = (string)b.Attribute("style")
                    };

        foreach (var beer in beers)
        {
            Console.WriteLine($"{beer.Name} - {beer.Style}");
        }
    }
}

class Beer
{
    public string Name { get; set; }
    public string Style { get; set; }
}

