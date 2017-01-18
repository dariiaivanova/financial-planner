using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using financialplanner.Data;

namespace Service
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IUserService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        bool Register(string email, string password);

        [OperationContract]
        bool LogIn(string email, string password);

        [OperationContract]
        bool ResetPassword(string email);

        [OperationContract]
        void ExportUser(string email, string password);
    }
}
