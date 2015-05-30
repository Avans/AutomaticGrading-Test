using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ALG_Practicum_week1;

namespace UnitTestALG_Practicum_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NawArrayOngeordend_constructor_test()
        {
            try
            {
                NawArrayOngeordend array = new NawArrayOngeordend(0);
                Assert.Fail("\n\nTIP: De minimale grootte waarop de NawArrayOngeordend geinitialiseerd mag worden zou minimaal 1 moeten zijn.\n");
            }
            catch(NawArrayOngeordendInvalidSizeException)
            {
                    
            }

            try
            {
                NawArrayOngeordend array = new NawArrayOngeordend(1000001);
                Assert.Fail("\n\nTIP: De maximale grootte waarop de NawArrayOngeordend geinitialiseerd mag worden zou maximaal 1.000.000 moeten zijn.\n");
            }
            catch (NawArrayOngeordendInvalidSizeException)
            {

            }

        }

        [TestMethod]
        public void NawArrayOngeordend_voegtoe_test()
        {
            // -Er moeten net zoveel items toegevoegd kunnen worden als de opgegeven omvang bij creatie
            var array = new NawArrayOngeordend(10);
            NAW persoon;

            for (int i=0;i<10;i++)
            {
                persoon = new NAW("N", "A", "W");
                try 
                {
                    array.VoegToe(persoon);
                }
                catch (NawArrayOngeordendOutOfBoundsException)
                {
                    Assert.Fail("\n\nEr konden maar {0} NAW-objecten aan een array die met omvang 10 is geinitialiseerd worden toegevoegd", i);
                }
            }

            // -Bij het toevoegen aan volle array moet exceptie komen
            persoon = new NAW("N", "A", "W");
            var exceptie = false;
            try 
            {
                array.VoegToe(persoon);
            }
            catch (NawArrayOngeordendOutOfBoundsException)
            {
                exceptie = true;
            }
            Assert.IsTrue(exceptie, "\n\nToevoegen van 11e element aan array met omvang van 10 geeft geen exceptie");
        }
    }
}
