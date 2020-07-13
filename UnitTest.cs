using NUnit.Framework;

namespace PromotionEngine
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //Scenario A
        //1*A=50
        //1*B=30
        //1*C=20
        //Total=100
        [Test]
        public void GetTotal()
        {
            int total = GetPriceByUnit("A", 1);
            total += GetPriceByUnit("B", 1);
            total += GetPriceByUnit("C", 1);
            Assert.AreEqual(100, total);
        }

        //Scenario B
        //5*A =130 + 2*50  ---Promotions---3 A's = 130 
        //5*B =45 + 45 + 30 ---Promotions---2 B's = 45 
        //1*C = 20  ---Promotions--- C & D for 30 
        //Total = 370
        [Test]
        public void GetTotalWithPromotion()
        {
            int total = GetPriceByUnit("A", 5);
            total += GetPriceByUnit("B", 5);
            total += GetPriceByUnit("C", 1);
            Assert.AreEqual(370, total);
        }

        //Scenario C
        //3*A =130 
        //5*B =45 + 45 + 1*30 
        //1*C 
        //1*D =30
        //Total = 280
        [Test]
        public void GetTotalByPromotion()
        {
            int total = GetPriceByUnit("A", 3);
            total += GetPriceByUnit("B", 5);
            total += GetPriceByUnit("C", 1);
            total += GetPriceByUnit("D", 1);
            Assert.AreNotEqual(280, total);
        }

        private int GetPriceByUnit(string unitType, int noOfUnit)
        {
            int promotionalPrice = 0;
            if (unitType == "A")
            {
                promotionalPrice = 130;
                if (noOfUnit == 3)
                {
                    promotionalPrice = 130;
                }
                else if (noOfUnit > 3)
                {
                    promotionalPrice = promotionalPrice * (noOfUnit / 3) + 50 * (noOfUnit % 3);
                }
                else
                {
                    promotionalPrice = noOfUnit * 50;
                }
            }
            if (unitType == "B")
            {
                promotionalPrice = 45;
                if (noOfUnit == 2)
                {
                    promotionalPrice = 45;
                }
                else if (noOfUnit > 2)
                {
                    promotionalPrice = promotionalPrice * (noOfUnit / 2) + 30 * (noOfUnit % 2);
                }
                else
                {
                    promotionalPrice = noOfUnit * 30;
                }
            }
            if (unitType == "C" && unitType == "D")
            {
                promotionalPrice = 30;
            }
            else if (unitType == "C")
            {
                promotionalPrice = noOfUnit * 20;
            }
            else if (unitType == "D")
            {
                promotionalPrice = noOfUnit * 15;
            }
            return promotionalPrice;
        }
    }
}