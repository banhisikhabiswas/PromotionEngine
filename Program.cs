using System;

namespace PromotionEngineClient
{
    class Program
    {
        static void Main(string[] args)
        {     
            PromotionEngine promotionEngineObj = new PromotionEngine();
            int total = 0;
            string strA, strB, strC, strD;

            Console.WriteLine("Enter SKU Ids for Scenario A...");
            strA = Console.ReadLine();
            strB = Console.ReadLine();
            strC = Console.ReadLine();
            //Scenario A    
            //1*A=50
            //1*B=30
            //1*C=20
            //Total=100
            total = promotionEngineObj.GetPriceByUnit(strA, 1) + promotionEngineObj.GetPriceByUnit(strB, 1) + promotionEngineObj.GetPriceByUnit(strC, 1);
            Console.WriteLine("Total is " + total);


            Console.WriteLine("Enter SKU Ids for Scenario B...");          
            strA = Console.ReadLine();
            strB = Console.ReadLine();
            strC = Console.ReadLine();
            //Scenario B
            //5*A =130 + 2*50  ---Promotions---3 A's = 130 
            //5*B =45 + 45 + 30 ---Promotions---2 B's = 45 
            //1*C = 20  ---Promotions--- C & D for 30 
            //Total = 370
            total = promotionEngineObj.GetPriceByUnit(strA,5) + promotionEngineObj.GetPriceByUnit(strB,5) + promotionEngineObj.GetPriceByUnit (strC,1);
            Console.WriteLine("Total is " + total);


            Console.WriteLine("Enter SKU Ids for Scenario C...");
            strA = Console.ReadLine();
            strB = Console.ReadLine();
            strC = Console.ReadLine();
            strD = Console.ReadLine();
            //Scenario C
            //3*A =130 
            //5*B =45 + 45 + 1*30 
            //1*C 
            //1*D =30
            //Total = 280
            total = promotionEngineObj.GetPriceByUnit(strA,3) + promotionEngineObj.GetPriceByUnit(strB,5) + promotionEngineObj.GetPriceByUnit(strC,1) + promotionEngineObj.GetPriceByUnit(strD,1);
            Console.WriteLine("Total is " + total);
            Console.Read();
        }
    }
}
