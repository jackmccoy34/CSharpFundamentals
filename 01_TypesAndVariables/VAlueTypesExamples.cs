using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class VAlueTypesExamples
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool isDeclared;
            isDeclared = true;
            bool isdeclarationAndInitialized = true;
            // some notes
        }

        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte sByteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            int a = 15;
            int b = 22;
            int c = 37;
            byte age = 254;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal decimalExample = 1.25789072890457897897897897m;
            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        enum PastryType {Cake, Doughnut, Scone, Cupcake, Croissant}

        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Doughnut;
            PastryType anotherOne = PastryType.Scone;
            Console.WriteLine(myPastry);
            Console.WriteLine(anotherOne);
        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;
            DateTime today = DateTime.MinValue;
            Console.WriteLine(today);
            DateTime birthday = new DateTime(2020, 11, 24);
            Console.WriteLine(birthday.ToShortDateString());
        }

        [TestMethod]
        public void Challenges()
        {
            bool Allergic;
            Allergic = true;
            Console.WriteLine(Allergic);

            bool Immune = false;
            Console.WriteLine(Immune);

            float a = 13.5f;
            Console.WriteLine(a);

            byte byteChallenge = 240;
            Console.WriteLine(byteChallenge);

            int b = 12;
            Console.WriteLine(b);
        }

        enum SportType { Football, Basketball, Golf, Hockey}

        [TestMethod]
        public void Enum2()
        {
            SportType mySport = SportType.Basketball;
            SportType yourSport = SportType.Football;
            Console.WriteLine(mySport);
            Console.WriteLine(yourSport);
        }
    }
}
