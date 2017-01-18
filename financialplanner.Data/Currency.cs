using System.Runtime.Serialization;

namespace financialplanner.Data
{
    [DataContract]
    public enum Currency: int

    {
        USD=1, GBP=2, UAH=3
    }
}