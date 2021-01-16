using AbstractFactoryPattern.Interfaces.TypePhone;

namespace AbstractFactoryPattern.Interfaces
{
    public interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }
}
