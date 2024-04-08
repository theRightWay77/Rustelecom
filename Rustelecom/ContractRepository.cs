using Rustelecom.Models;
using System.Net;

namespace Rustelecom
{
    public class ContractRepository : IContractRepository
    {
        public List<Contract> Contracts { get; set; } = new List<Contract>()
        {
            new Contract("Илья Ефимович Репин", "192.168.0.1", ServiceType.VideoControl, DateTime.Now),
            new Contract("Иван Николаевич Крамской", "10.0.0.1", ServiceType.IPTelephony, DateTime.Now),
            new Contract("Василий Васильевич Верещагин", "172.16.0.1", ServiceType.VideoControl, DateTime.Now),
            new Contract("Иван Иванович Шишкин", "255.255.255.0", ServiceType.Internet, DateTime.Now),
            new Contract("Василий Дмитриевич Поленов", "134.201.250.5", ServiceType.Internet, DateTime.Now),
            new Contract("Александр Иванович Иванов", "8.8.8.8", ServiceType.VideoControl, DateTime.Now),
            new Contract("Михаил Васильевич Нестеров", "216.58.214.46", ServiceType.IPTelephony, DateTime.Now),
            new Contract("Иван Алексеевич Айвазовский", "123.45.67.89", ServiceType.VideoControl, DateTime.Now),
            new Contract("Виктор Михайлович Васнецов", "172.31.255.255", ServiceType.IPTelephony, DateTime.Now),
            new Contract("Валентин Сергеевич Серов", "198.51.100.1", ServiceType.IPTelephony, DateTime.Now),
        };

        public List<Contract> GetContracts()
        {
            return Contracts;
        }
        

          public Contract TryGetById(int id) 
        {
            return Contracts.FirstOrDefault(x => x.Id == id);
        }
    }
}
