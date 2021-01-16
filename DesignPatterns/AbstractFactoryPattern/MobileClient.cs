using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Interfaces.TypePhone;

namespace AbstractFactoryPattern
{
    public class MobileClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public MobileClient(IMobilePhone factory)
        {
            smartPhone = factory.GetSmartPhone();
            normalPhone = factory.GetNormalPhone();
        }

        public string GetSmartPhoneModelDetails()
        {
            return smartPhone.GetModelDetails();
        }

        public string GetNormalPhoneModelDetails()
        {
            return normalPhone.GetModelDetails();
        }

        //https://www.c-sharpcorner.com/article/abstract-factory-design-pattern-in-c-sharp/
    }
}
