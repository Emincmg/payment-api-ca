using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PaymentApıCA.Application.DTOs;
using PaymentApıCA.Application.Interfaces.Payment;

namespace PaymentApıCA.Application.Services.Payment;

public class StripePayment : IPayment
{
    public int Id { get; set; }
    public float Amount { get; set; }
    public required string Currency { get; set; }
    public required string Status { get; set; }
    public DateTime? ConfirmedAt { get; set; }
    public DateTime? DeclinedAt { get; set; }
    public int Tries { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public StripePayment(IConfiguration configuration, ILogger<StripePayment> logger)
    {
        
    }
    
    public Task<PaymentDto> Process()
    {
        throw new NotImplementedException();
    }

    public PaymentDto Decline(PaymentDto dto)
    {
        throw new NotImplementedException();
    }

    public PaymentDto Success(PaymentDto dto)
    {
        throw new NotImplementedException();
    }
}
