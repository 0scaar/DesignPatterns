using AbstractFactoryPattern.Interfaces.TypePhone;
using AbstractFactoryPattern.Message;

namespace AbstractFactoryPattern.Product.Normal
{
    public class Nokia1600 : INormalPhone
    {
        public string GetModelDetails()
        {
            return Description.Nokia1600;
        }
    }
}
