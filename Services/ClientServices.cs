using ClientManager.Models;

namespace ClientManager.Services
{
    public class ClientServices
    {
        static List<Client> Clients { get; }
        static int idCounter = 7;
        static ClientServices()
        {
            Clients = new List<Client>
            {
                new Client { id = 1, firstName = "João", lastName = "Gens", age = 32, email = "joaogens@it.pt", phoneNumber = "919999999" },
                new Client { id = 2, firstName = "Maria", lastName = "Silva", age = 28, email = "mariasilva@it.pt", phoneNumber = "919888888" },
                new Client { id = 3, firstName = "Pedro", lastName = "Santos", age = 35, email = "pedrosantos@it.pt", phoneNumber = "919777777" },
                new Client { id = 4, firstName = "Ana", lastName = "Costa", age = 30, email = "anacosta@it.pt", phoneNumber = "919666666" },
                new Client { id = 5, firstName = "Luís", lastName = "Ferreira", age = 40, email = "luisf@it.pt", phoneNumber = "919555555" },
                new Client { id = 6, firstName = "Carla", lastName = "Pereira", age = 27, email = "carlap@it.pt", phoneNumber = "919444444" }
            };
        }

        public static List<Client> GetAll() => Clients;
        public static Client? GetClient(int id) => Clients.FirstOrDefault(c => c.id == id);

        public static void Add(Client client)
        {
            idCounter++;
            Clients.Add(client);
        }
        public static void Delete(int id)
        {
            var client = GetClient(id);
            if (client is null)
                return;
            Clients.Remove(client);
        }
        public static void Update(Client client)
        {
            var index = Clients.FindIndex(c => c.id == client.id);
            if (index == -1)
                return;
            Clients[index] = client;
        }
        public static void UpdatePartial(int id, Client client)
        {
            var index = Clients.FindIndex(c => c.id == id);
            if (index == -1)
                return;
            if (client.firstName != null)
                Clients[index].firstName = client.firstName;
            if (client.lastName != null)
                Clients[index].lastName = client.lastName;
            if (client.age != 0)
                Clients[index].age = client.age;
            if (client.email != null)
                Clients[index].email = client.email;
            if (client.phoneNumber != null)
                Clients[index].phoneNumber = client.phoneNumber;
        }
    }
}



        