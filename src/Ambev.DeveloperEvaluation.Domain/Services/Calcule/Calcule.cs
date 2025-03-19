using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Services.Calcule;

public class Calcule : ICalcule
{
    public decimal Discount(List<SaleItem> saleItem)
    {
        decimal discount = 0;
        foreach (var item in saleItem)
        {
            if (item.Quantities > 4)
            {
                discount = Convert.ToDecimal("0,1");
            }

            if (item.Quantities >= 10 && item.Quantities <= 20)
            {
                discount = Convert.ToDecimal("0,2");
            }
        }
        return discount;
    }

    public bool QuantityValid(List<SaleItem> saleItem)
    {
        foreach (var item in saleItem)
        {
            if (item.Quantities > 20)
            {
                return false;
            }
        }
        return true;
    }

    public decimal TotalSaleAmount(decimal total, decimal discount)
    {
        if (discount > 0)
        {
            return total - total * discount;
        }
        else
        {
            return total;
        }
    }

}
