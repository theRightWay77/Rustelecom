using Microsoft.AspNetCore.Mvc;
using Rustelecom.Models;

namespace Rustelecom.Controllers
{
    public class ContractController : Controller
    {
        IContractRepository ContractRepository { get; set; }

        public ContractController(IContractRepository contractRepository)
        {
            ContractRepository = contractRepository;
        }

        public IActionResult Index()
        {
            List<Contract> contracts = ContractRepository.GetContracts();
            return View(contracts);
        }

        public IActionResult ChangeStatus(int id) 
        {
            Contract contract = ContractRepository.TryGetById(id);
            if (contract.Status == Status.InProcess)
            {
                contract.Status = Status.Refused;
            }
            else
            {
                contract.Status = Status.InProcess;
            }
            return RedirectToAction("Index");
        }

        

    }
}
