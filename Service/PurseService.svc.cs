using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using financialplanner.Data;

namespace Service
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "PurseService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы PurseService.svc или PurseService.svc.cs в обозревателе решений и начните отладку.
    public class PurseService : IPurseService
    {
        private readonly static List<Purse> Purses = new List<Purse>();

        public bool NewPurse(string name)
        {
            Purses.Add(new Purse(Purses.Count)
            {
                Name = name
            });
            return true;
        }

        public Purse GetPurse(string name)
        {
            return (from purse in Purses
                    where purse.Name.Equals(name)
                    select purse).First();
        }

        public bool UpdatePurse(Purse purse)
        {
            for (var i = 0; i < Purses.Count; i++)
            {
                if (!Purses[i].Id.Equals(purse.Id)) continue;

                Purses[i] = purse;
                return true;
            }

            return false;
        }
    }
}
