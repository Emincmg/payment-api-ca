using PaymentApıCA.Application.Common.FluentValidations;
using PaymentApıCA.Application.Common.Interfaces;
using PaymentApıCA.Domain.Events;

namespace PaymentApıCA.Application.Payments.Commands.CreatePayment;

public record CreatePaymentCommand : IRequest<int>
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
}

public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreatePaymentCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    

    public async Task<int> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
    {
        var entity = new Domain.Entities.Payment
        {
             Channel = request.Channel,
                Amount = request.Amount,
                Currency = request.Currency,
                Description = request.Description,
                UserName = request.UserName,
                UserEmail = request.UserEmail,
                UserPhone = request.UserPhone,
                PaymentMethod = request.PaymentMethod,
                ConfirmationMethod = request.ConfirmationMethod
        };

        
        
        entity.AddDomainEvent(new PaymentCreatedEvent(entity));

        _context.Payments.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
