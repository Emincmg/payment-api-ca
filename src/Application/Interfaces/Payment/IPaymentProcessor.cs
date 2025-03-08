using PaymentApıCA.Application.DTOs;

namespace PaymentApıCA.Application.Interfaces.Payment;

public interface IPaymentProcessor
{
    public Task<PaymentDto>? Process();
}
