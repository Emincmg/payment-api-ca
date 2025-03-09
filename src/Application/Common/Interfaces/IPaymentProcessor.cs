using PaymentApıCA.Application.Common.Models;

namespace PaymentApıCA.Application.Common.Interfaces;

public interface IPaymentProcessor
{
    public Task<PaymentDto>? Process();
}
