using AutoMapper;
namespace PaymentApıCA.Domain.Entities;

public class Payment : BaseAuditableEntity
{
    public required string Channel { get; set; }
    public float Amount { get; set; }
    public required string Currency { get; set; }
    public string? Description { get; set; }
    public string? UserName { get; set; }
    public string? UserEmail { get; set; }
    public string? UserPhone { get; set; }
    public string? PaymentMethod { get; set; }
    public string? ConfirmationMethod { get; set; }

}
