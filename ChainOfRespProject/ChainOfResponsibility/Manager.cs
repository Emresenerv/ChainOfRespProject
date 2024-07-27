using ChainOfRespProject.DAL;
using ChainOfRespProject.Models;

namespace ChainOfRespProject.ChainOfResponsibility
{
    public class Manager : Employee
    {
        private readonly Context _context;

        public Manager(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerProcessViewModel model)
        {
            if (model.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployeeName = "Emre Kaya";
                customerProcess.Description = "İstenen tutar müşteriye Şube Müdürü Tarafından Ödendi";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();

            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployeeName = "Emre Kaya";
                customerProcess.Description = "Ödeme Şube Müdürü taradından Yapılamadı ve İşlem Bölge Müdürüne Gönderildi.";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
                NextApprover.ProcessRequest(model);

            }


        }
    }
    }

