using ClientManager.Model;

namespace ClientManager.Services
{
    public class ClientServices
    {
        static List<Client>  Clients = new List<Client>
        {
            new Client { id = 1, firstName = "João", lastName = "Gens", age = 32, email = "joaogens@it.pt", phoneNumber = "919999999" },
            new Client { id = 2, firstName = "Maria", lastName = "Silva", age = 28, email = "mariasilva@it.pt", phoneNumber = "919888888" },
            new Client { id = 3, firstName = "Pedro", lastName = "Santos", age = 35, email = "pedrosantos@it.pt", phoneNumber = "919777777" },
            new Client { id = 4, firstName = "Ana", lastName = "Costa", age = 30, email = "anacosta@it.pt", phoneNumber = "919666666" },
            new Client { id = 5, firstName = "Luís", lastName = "Ferreira", age = 40, email = "luisf@it.pt", phoneNumber = "919555555" },
            new Client { id = 6, firstName = "Carla", lastName = "Pereira", age = 27, email = "carlap@it.pt", phoneNumber = "919444444" }
            };
    }
}



        