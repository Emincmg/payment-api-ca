using PaymentApıCA.Application.Common.Interfaces;
using PaymentApıCA.Application.Common.Models;
using PaymentApıCA.Application.Common.Strategies;

namespace PaymentApıCA.Application.Common.Factories;

public class PaymentFactory : IPaymentStrategy
{
    private readonly IMapper _mapper;

    public PaymentFactory(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public IPayment GetPayment(PaymentDto paymentDto)
    {
        return paymentDto.PaymentMethod switch
        {
            "paypal" => _mapper.Map<PayPalPayment>(paymentDto),
            "stripe"=> _mapper.Map<StripePayment>(paymentDto),
            _ => throw new NotImplementedException()
        };
    }
}
