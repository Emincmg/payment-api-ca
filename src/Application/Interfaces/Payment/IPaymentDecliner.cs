using PaymentApıCA.Application.DTOs;

namespace PaymentApıCA.Application.Interfaces.Payment;

public interface IPaymentDecliner
{
    public PaymentDto Decline(PaymentDto dto);
}
