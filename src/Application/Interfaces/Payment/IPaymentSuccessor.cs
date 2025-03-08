using PaymentApıCA.Application.DTOs;

namespace PaymentApıCA.Application.Interfaces.Payment;

public interface IPaymentSuccessor
{
    public PaymentDto Success(PaymentDto dto);
}
