namespace PaymentApıCA.Domain.Events;

public class PaymentCreatedEvent : BaseEvent
{
    public PaymentCreatedEvent(Payment payment)
    {
        Payment = payment;
    }

    public Payment Payment { get; }
}
