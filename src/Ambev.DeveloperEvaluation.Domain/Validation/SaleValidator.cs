using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class SaleValidator : AbstractValidator<Sale>
{
    public SaleValidator()
    {

        RuleFor(sale => sale.SaleItem.Sum(a=>a.Quantities))
          .GreaterThan(20).WithMessage("Não é possível vender mais de 20 itens idênticos.");
      
        RuleFor(sale => sale.Status)
            .NotEqual(SaleStatus.Unknown)
            .WithMessage("Status da venda não pode ser desconhecido.");
    }
}
