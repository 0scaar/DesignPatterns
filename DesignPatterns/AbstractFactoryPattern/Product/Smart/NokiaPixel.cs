using AbstractFactoryPattern.Interfaces.TypePhone;
using AbstractFactoryPattern.Message;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Product.Smart
{
    public class NokiaPixel : ISmartPhone
    {
        public string GetModelDetails() => Description.NokiaPixel;
    }
}
