using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using financialplanner.Data;

namespace Service
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IPurseService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IPurseService
    {
        [OperationContract]
        bool NewPurse(string name);

        [OperationContract]
        Purse GetPurse(string name);

        [OperationContract]
        bool UpdatePurse(Purse purse);
    }
}
