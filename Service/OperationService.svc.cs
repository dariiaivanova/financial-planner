using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using financialplanner.Data;

namespace Service
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "OperationOperationService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы OperationOperationService.svc или OperationOperationService.svc.cs в обозревателе решений и начните отладку.
    public class OperationOperationService : IOperationService
    {

        public bool Create(Purse purse, double sum, string name, Currency currency, Category category, string note, DateTime date, string place, bool isExpense)
        {
            var op = purse.CreateOperation(sum, name, currency, category, note, date, place, isExpense);
            purse.ChangeBalance(op);
            purse.SaveOperation(op);

            return true;
        }

        public IList<Operation> Read(Purse obj)
        {
            return obj.Operations;
        }
    }
}
