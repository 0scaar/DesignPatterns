using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Interfaces.TypePhone;
using AbstractFactoryPattern.Product.Normal;
using AbstractFactoryPattern.Product.Smart;

namespace AbstractFactoryPattern.Company
{
    public class Nokia : IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        { 
            return new Nokia1600(); 
        }

        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
