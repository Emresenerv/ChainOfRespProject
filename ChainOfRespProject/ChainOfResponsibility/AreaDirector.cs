using ChainOfRespProject.DAL;
using ChainOfRespProject.Models;

namespace ChainOfRespProject.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        private readonly Context _context;

        public AreaDirector(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerProcessViewModel model)
        {
            if (model.Amount <= 350000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployeeName = "Emre Öz";
                customerProcess.Description = "İstenen tutar müşteriye Bölge Müdürü Tarafından Ödendi";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();

            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployeeName = "Emre Öz";
                customerProcess.Description = "Günlük ödeme limitlerini Aştığı için ödeme yapılamadı,Müşteriye Bilgi verildi.";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
               

            }


        }
    }
}
