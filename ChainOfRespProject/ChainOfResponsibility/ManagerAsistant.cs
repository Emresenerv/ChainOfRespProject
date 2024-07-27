using ChainOfRespProject.DAL;
using ChainOfRespProject.Models;

namespace ChainOfRespProject.ChainOfResponsibility
{
    public class ManagerAsistant : Employee
    {
        private readonly Context _context;

        public ManagerAsistant(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerProcessViewModel model)
        {
            if (model.Amount <=150000) 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                 customerProcess.Name = model.Name;
                customerProcess.EmployeeName = "Emre Şen";
                customerProcess.Description = "İstenen tutar müşteriye Şube Müdür Yardımcısı Tarafından Ödendi";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();

            }
            else if(NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployeeName = "Emre Şen";
                customerProcess.Description = "Ödeme Şube Müdür Yardımcısı taradından Yapılamadı ve İşlem Şube Müdürüne Gönderildi.";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
                NextApprover.ProcessRequest(model);

            }
             
           
        }
    }
}
