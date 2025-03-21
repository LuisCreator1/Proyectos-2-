using System;
using System.IO;
using System.Reflection.PortableExecutable;
using Json.Net_Sample.Model;
using Newtonsoft.Json;

namespace Json.Net_Sample

{

    class Program
    {
        private static string path = @"C:\Json Sample\contacts.json";
        private static string _paht;
        private static object contacts;
        private static bool contactsJsonFromFile;
        private static contacts sonFromFile;

        static void Main(string[] args)

        {
            //var contacts = GetContacts();
            //SerializeJsonFile(contacts);

            //var contacts = GetContactsJsonfromfile();
            //DeserlalizeJsonFile(contacts);
        }

        private static void DeserlalizeJsonFile(object contacts)
        {
            throw new NotImplementedException();
        }

        private static object GetContactsJsonfromfile()
        {
            throw new NotImplementedException();
        }
        #region "Writing JSON"
        public static void SerializeJsonFile(List<Contact> contact)
        {
            string contactsJson = JsonConvert.SerializeObject(contacts.ToArray(),
                Formatting.Indented);

            File.WriteAllText(_paht, contactsJson);
        }
        public static List<Contact> GetContacts()
        {
            var contacts = new List<Contact>
    {
        new Contact
        {
            Name = "John Wick",
            DateOfBirth = new DateTime(1980, 5, 17),
            Address = new Address
            {
                Street = "Centennial Drive",
                Number = 15,
                City = new City
                {
                    Name = "New York",
                    Country = new Country
                    {
                        Code = "US",
                        Name = "United States"
                    }
                }
            },
            Phones = new List<Phone>
            {
                new Phone { Name = "Personal", Number = "123456789" },
                new Phone { Name = "Work", Number = "987654321" }
            }
        },
        new Contact
        {
            Name = "Alfred Hitchcock",
            DateOfBirth = new DateTime(1899, 8, 13),
            Address = new Address
            {
                Street = "Mariscal Lamar",
                Number = 1260,
                City = new City
                {
                    Name = "Lima",
                    Country = new Country
                    {
                        Code = "PE",
                        Name = "Peru"
                    }
                }
            },
            Phones = new List<Phone>
            {
                new Phone { Name = "Personal", Number = "111111111" },
                new Phone { Name = "Work", Number = "222222222" }
            }
        },
        new Contact
        {
            Name = "Paul Thomas Anderson",
            DateOfBirth = new DateTime(1970, 6, 26),
            Address = new Address
            {
                Street = "Avenida 9 de Julio",
                Number = 532,
                City = new City
                {
                    Name = "Buenos Aires",
                    Country = new Country
                    {
                        Code = "AR",
                        Name = "Argentina"
                    }
                }
            },
            Phones = new List<Phone>
            {
                new Phone { Name = "Personal", Number = "333333333" },
                new Phone { Name = "Work", Number = "444444444" }
            }
        }
    };

            return contacts;
        }
        #endregion

        public static string GetContactsJsonFromFile()
            
        {
            string contactsJsonFromFile;
            using (var reader = new StreamReader(path))

            {
              contactsJsonFromFile = reader.ReadToEnd();
            }

            return contactsJsonFromFile;
        }

        public static void DeserializeJsonFile(string contactsIsonFromFile, bool contactsJsonFromFile)
        {
            Console.WriteLine(contactsJsonFromFile);

            var contacts = JsonConvert.DeserializeObject<Liste<Contact>>(contactsJsonFromFile);

            Console.WriteLine(string.Format("Paul T. Anderson's Address is: {0} {1}",
                contacts[2]Address.Street, contacts[2].Address.Number)));

            Console.WriteLine(string.Format("John Wick's Address is: {0}",
               contacts[0].DateOfBirth.ToShortDataString()));




        }
    }
} 
