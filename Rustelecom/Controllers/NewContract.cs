using Microsoft.AspNetCore.Mvc;
using Rustelecom.Models;
using System.Reflection;

namespace Rustelecom.Controllers
{
    //public enum ServiceType
    //{
    //    Internet,
    //    VideoControl,
    //    IPTelephony
    //}
    public class NewContract : Controller
    {
        IContractRepository ContractRepository { get; set; }

        public NewContract(IContractRepository contractRepository)
        {
            ContractRepository = contractRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

      
        [HttpPost]
        public IActionResult SaveNew(Contract contract, int serviseType)
        {
            if (serviseType == 0) contract.ServiceType = ServiceType.Internet;
            else if (serviseType == 1) contract.ServiceType = ServiceType.VideoControl;
            else if (serviseType == 2) contract.ServiceType = ServiceType.IPTelephony;
                        
            if (ModelState.IsValid)
            {
                ContractRepository.Contracts.Add(contract);
                 return RedirectToAction("Index", "Contract");
            }

            return View("Index", contract);
                      
        }
    }
}
