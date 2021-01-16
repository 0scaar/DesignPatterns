using AbstractFactoryPattern.Interfaces.TypePhone;
using AbstractFactoryPattern.Message;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Product.Smart
{
    public class SamsungGalaxy : ISmartPhone
    {
        public string GetModelDetails() => Description.SamsungGalaxy;
    }
}
