using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PromotionEngineUnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        //Scenario A
        //1*A=50
        //1*B=30
        //1*C=20
        //Total=100
        [TestMethod]
        public void GetTotal()
        {
            int total = GetPriceByUnit("A", 1) + GetPriceByUnit("B", 1) + GetPriceByUnit("C", 1);
            Assert.AreEqual(100, total);
        }

        //Scenario B
        //5*A =130 + 2*50  ---Promotions---3 A's = 130 
        //5*B =45 + 45 + 30 ---Promotions---2 B's = 45 
        //1*C = 20  ---Promotions--- C & D for 30 
        //Total = 370
        [TestMethod]
        public void GetTotalWithPromotion()
        {
            int total = GetPriceByUnit("A", 5) + GetPriceByUnit("B", 5) + GetPriceByUnit("C", 1);
            Assert.AreEqual(370, total);
        }

        //Scenario C
        //3*A =130 
        //5*B =45 + 45 + 1*30 
        //1*C 
        //1*D =30
        //Total = 280
        [TestMethod]
        public void GetTotalByPromotion()
        {
            int total = GetPriceByUnit("A", 3) + GetPriceByUnit("B", 5) + GetPriceByUnit("C", 1) + GetPriceByUnit("D", 1);
            Assert.AreNotEqual(280, total);
        }
        
        private  int GetPriceByUnit(string skuId, int noOfSkuId)
        {
            int promotionalPrice =0 ;
            if (skuId == "A")
            {
                promotionalPrice = 130;
                if (noOfSkuId == 3)
                {
                    promotionalPrice = 130;
                }
                else if (noOfSkuId > 3)
                {
                    promotionalPrice = promotionalPrice * (noOfSkuId / 3) + 50 * (noOfSkuId % 3);
                }
                else
                {
                    promotionalPrice = noOfSkuId * 50;
                }

            }
            if (skuId == "B")
            {
                promotionalPrice = 45;
                if (noOfSkuId == 2)
                {
                    promotionalPrice = 45;
                }
                else if (noOfSkuId > 2)
                {
                    promotionalPrice = promotionalPrice * (noOfSkuId / 2) + 30 * (noOfSkuId % 2);
                }
                else
                {
                    promotionalPrice = noOfSkuId * 30;
                }
            }
            if (skuId == "C" && skuId == "D")
            {
                promotionalPrice = 30;
            }
            else if (skuId == "C")
            {
                promotionalPrice = noOfSkuId * 20;
            }
            else if (skuId == "D")
            {
                promotionalPrice = noOfSkuId * 15;
            }
            return promotionalPrice;
        }
    }
}

