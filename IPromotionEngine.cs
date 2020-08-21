using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineClient
{
    interface IPromotionEngine
    {
        int GetPriceByUnit(string skuId, int noOfSkuId);
    }
}
