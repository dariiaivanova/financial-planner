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
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IUserService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IOperationService
    {
        [OperationContract]
        bool Create(Purse purse, double sum, string name, Currency currency, Category category, string note, DateTime date, string place, bool isExpense);

        [OperationContract]
        IList<Operation> Read(Purse obj);
    }
}
