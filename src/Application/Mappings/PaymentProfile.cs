using PaymentApıCA.Application.DTOs;
using PaymentApıCA.Application.Interfaces.Payment;

namespace PaymentApıCA.Application.Mappings;

public class PaymentProfile : Profile
{
    public PaymentProfile()
    {
        CreateMap<IPayment, PaymentDto>().ReverseMap();
        
        //uncomment to map the concrete payment classes, use case would be different properties for different payment methods...
        /*
         CreateMap<PayPalPayment, PaymentDto>().ReverseMap();
        CreateMap<StripePayment, PaymentDto>().ReverseMap();
        */ 
    }
}
