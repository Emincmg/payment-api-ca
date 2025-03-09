using PaymentApıCA.Application.Common.Models;

namespace PaymentApıCA.Application.Common.Interfaces;

public interface IPaymentDecliner
{
    public PaymentDto Decline(PaymentDto dto);
}
