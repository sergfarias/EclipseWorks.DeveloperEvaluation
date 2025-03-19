using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Services.Calcule;

public interface ICalcule
{
    decimal Discount(List<SaleItem> saleItem);
    bool QuantityValid(List<SaleItem> saleItem);
    decimal TotalSaleAmount(decimal total, decimal discount);
}
