using AbstractFactoryPattern;
using AbstractFactoryPattern.Company;
using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Message;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests.CreationalPatterns.AbstractFactory
{
    public class AbstractFactoryTest
    {
        [Fact]
        public void NokiaPhoneTest()
        {
            IMobilePhone NokiaMobilePhone = new Nokia();
            MobileClient NokiaClient = new MobileClient(NokiaMobilePhone);

            var descriptionNormalPhone = NokiaClient.GetNormalPhoneModelDetails();
            var descriptionSmartPhone = NokiaClient.GetSmartPhoneModelDetails();

            descriptionNormalPhone.Equals(Description.Nokia1600).Should().BeTrue();
            descriptionSmartPhone.Equals(Description.NokiaPixel).Should().BeTrue();
        }

        [Fact]
        public void SamsungPhoneTest()
        {
            IMobilePhone SamsungMobilePhone = new Samsung();
            MobileClient SamsungClient = new MobileClient(SamsungMobilePhone);

            var descriptionNormalPhone = SamsungClient.GetNormalPhoneModelDetails();
            var descriptionSmartPhone = SamsungClient.GetSmartPhoneModelDetails();

            descriptionNormalPhone.Equals(Description.SamsungGuru).Should().BeTrue();
            descriptionSmartPhone.Equals(Description.SamsungGalaxy).Should().BeTrue();
        }
    }
}
