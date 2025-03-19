using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a sale in the system .
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Sale : BaseEntity, ISale
{
    /// <summary>
    /// Gets the sale number.
    /// Must not be null or empty and should contain with 1 to 20 characters.
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// Gets the date and time when the sale was created.
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// Gets the unique identifier of the customer.
    /// </summary>
    /// <returns>The customer's ID as a string.</returns>
    public Guid CustomerId { get; set; }

    public Customer Customer { get; set; }

    
    public decimal TotalSaleAmount { get; set; } = 0;

    public decimal Discounts { get; set; } = 0;

    /// <summary>
    /// Gets the unique identifier of the branch.
    /// </summary>
    /// <returns>The branch's ID as a string.</returns>
    public Guid BranchId { get; set; }

    public Branch Branch { get; set; }

    public List<SaleItem> SaleItem { get; set; }

    /// <summary>
    /// Gets the sale's current status.
    /// Indicates whether the sale is cacelled or not cancelled in the system.
    /// </summary>
    public SaleStatus Status { get; set; }

    /// <summary>
    /// Gets the date and time when the sale was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets the date and time of the last update to the sale's information.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets the unique identifier of the sale.
    /// </summary>
    /// <returns>The sale's ID as a string.</returns>
    string ISale.Id => Id.ToString();

    /// <summary>
    /// Gets the sale number.
    /// </summary>
    /// <returns>The sele number.</returns>
    string ISale.SaleNumber => SaleNumber;

    /// <summary>
    /// Gets the sale date.
    /// </summary>
    /// <returns>The sale date.</returns>
    DateTime ISale.SaleDate => SaleDate;

    Guid ISale.CustomerId => CustomerId;

    /// <summary>
    /// Gets the total sale amoun.
    /// </summary>
    /// <returns>The total sale amount.</returns>
    decimal ISale.TotalSaleAmount => TotalSaleAmount;

    decimal ISale.Discounts => Discounts;

    Guid ISale.BranchId => BranchId;

    /// <summary>
    /// Initializes a new instance of the sale class.
    /// </summary>
    public Sale()
    {
        CreatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Performs validation of the user entity using the SaleValidator rules.
    /// </summary>
    /// <returns>
    /// A <see cref="ValidationResultDetail"/> containing:
    /// - IsValid: Indicates whether all validation rules passed
    /// - Errors: Collection of validation errors if any rules failed
    /// </returns>
    /// <remarks>
    /// <listheader>The validation includes checking:</listheader>
    /// <list type="bullet">Limit of 20 itens for product in sale</list>
    /// <list type="bullet">Status sale</list>
    /// </remarks>
    public ValidationResultDetail Validate()
    {
        var validator = new SaleValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }

    /// <summary>
    /// Activates the sale.
    /// Changes the sale's status to Active.
    /// </summary>
    public void Activate()
    {
        Status = SaleStatus.Active;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Cancelled the sale.
    /// Changes the sale's status to Cancelled.
    /// </summary>
    public void Deactivate()
    {
        Status = SaleStatus.Cancelled;
        UpdatedAt = DateTime.UtcNow;
    }

}