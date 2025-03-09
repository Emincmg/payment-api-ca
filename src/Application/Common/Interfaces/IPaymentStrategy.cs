using PaymentApıCA.Application.Common.Models;

namespace PaymentApıCA.Application.Common.Interfaces;

public interface IPaymentStrategy
{
    public IPayment GetPayment(PaymentDto paymentDto);
}
