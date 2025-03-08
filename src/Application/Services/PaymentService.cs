using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PaymentApıCA.Application.DTOs;
using PaymentApıCA.Application.FluentValidations;
using PaymentApıCA.Application.Interfaces.Payment;

namespace PaymentApıCA.Application.Services;

public class PaymentService
{
    private readonly ILogger<IPayment> _logger;
    private readonly IConfiguration _configuration;
    private PaymentDto? _paymentDto;
    private readonly PaymentValidator _paymentValidator;
    private readonly IPaymentStrategy _paymentFactory;

    public PaymentService(ILogger<IPayment> logger, IConfiguration configuration,
        IPaymentStrategy factory, PaymentValidator paymentValidator)
    {
        _logger = logger;
        _configuration = configuration;
        _paymentFactory = factory;
        _paymentValidator = paymentValidator;
    }

    public void SetPayment(PaymentDto paymentDto)
    {
        _paymentDto = paymentDto;
    }

    public IPayment GetPayment()
    {
        if (_paymentDto == null)
        {
            throw new ArgumentNullException(nameof(_paymentDto));
        }

        return _paymentFactory.GetPayment(_paymentDto);
    }

    public async Task<PaymentDto> ProcessPayment()
    {
        var payment = GetPayment();

        // first line of defense, check if payment is null :d
        if (payment == null)
        {
            throw new ArgumentNullException(nameof(payment));
        }

        // send the payment to the validator before processing
        _paymentValidator.Validate(payment);

        return await payment.Process()!;
    }
}
