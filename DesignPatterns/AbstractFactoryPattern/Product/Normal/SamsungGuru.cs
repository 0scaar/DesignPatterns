using AbstractFactoryPattern.Interfaces.TypePhone;
using AbstractFactoryPattern.Message;

namespace AbstractFactoryPattern.Product.Normal
{
    public class SamsungGuru : INormalPhone
    {
        public string GetModelDetails() => Description.SamsungGuru;
    }
}
