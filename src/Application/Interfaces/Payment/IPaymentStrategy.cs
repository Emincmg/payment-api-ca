using PaymentApıCA.Application.DTOs;

namespace PaymentApıCA.Application.Interfaces.Payment;

public interface IPaymentStrategy
{
    public IPayment GetPayment(PaymentDto paymentDto);
}
