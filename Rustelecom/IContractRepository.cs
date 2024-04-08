using Rustelecom.Models;

namespace Rustelecom
{
    public interface IContractRepository
    {
        List<Contract> Contracts { get; set; }
        List<Contract> GetContracts();
        Contract TryGetById(int id);
    }
}
