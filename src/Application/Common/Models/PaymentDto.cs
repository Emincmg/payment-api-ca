using PaymentApıCA.Application.Common.Interfaces;

namespace PaymentApıCA.Application.Common.Models;

public class PaymentDto
{
    public required string Channel { get; set; }
    public float Amount { get; set; }
    public required string Currency { get; set; }
    public string? Description { get; set; }
    public string? UserName { get; set; }
    public string? UserEmail { get; set; }
    public string? UserPhone { get; set; }
    public string? PaymentMethod { get; set; }
    public string? ConfirmationMethod { get; set; }

    private class PaymentProfile : Profile
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
}
