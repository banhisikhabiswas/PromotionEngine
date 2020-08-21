using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineClient
{
    public class PromotionEngine : IPromotionEngine
    {
        private int promotionalPrice;

        public int GetPriceByUnit(string skuId, int noOfSkuId)
        {
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
