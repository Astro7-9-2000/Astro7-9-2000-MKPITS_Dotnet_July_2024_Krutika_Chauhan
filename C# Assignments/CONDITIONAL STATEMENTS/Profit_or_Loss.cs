// C# Program to Calculate Profit and Loss

using System;

public class ProfitOrLoss
{
    static void Main()
    {
        int Cost_Price , Sell_Price , ProfitLossAmt;
        
        Console.Write("Calculate Profit or Loss.");
        
        // Enter the Cost price and Selling Price
        
        Console.Write("\nEnter the Cost Price: ");
        Cost_Price = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nEnter the Selling Price: ");
        Sell_Price = Convert.ToInt32(Console.ReadLine());
        
        // Applying the  conditions
        if(Cost_Price > Sell_Price)
        {
            ProfitLossAmt = Cost_Price - Sell_Price;
            Console.WriteLine("You can book your Profit amount: " +ProfitLossAmt);
        }
        else if (Sell_Price > Cost_Price)
        {
           ProfitLossAmt = Sell_Price - Cost_Price; 
           Console.WriteLine("You can book your loss now: " +ProfitLossAmt);
        }
        else
        {
            Console.WriteLine("You are running in no profit or loss condition.");
        }
    }
}