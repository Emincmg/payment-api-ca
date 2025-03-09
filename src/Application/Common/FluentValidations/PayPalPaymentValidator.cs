using PaymentApıCA.Application.Common.Strategies;

namespace PaymentApıCA.Application.Common.FluentValidations;

public class PayPalPaymentValidator : AbstractValidator<PayPalPayment>
{
    public PayPalPaymentValidator()
    {
        RuleFor(x => x.Amount).GreaterThan(0).WithMessage("Amount must be greater than zero.");
        RuleFor(x => x.Currency).NotEmpty().WithMessage("Currency is required.");
        RuleFor(x => x.Status).NotEmpty().WithMessage("Status is required.");
    }
}
