using PaymentApıCA.Application.Common.Models;

namespace PaymentApıCA.Application.Common.Interfaces;

public interface IPaymentSuccessor
{
    public PaymentDto Success(PaymentDto dto);
}
