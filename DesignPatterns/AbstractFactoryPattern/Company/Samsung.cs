using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Interfaces.TypePhone;
using AbstractFactoryPattern.Product.Normal;
using AbstractFactoryPattern.Product.Smart;

namespace AbstractFactoryPattern.Company
{
    public class Samsung : IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone GetSmartPhone() 
        {
            return new SamsungGalaxy();
        }
    }
}
