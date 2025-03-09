namespace PaymentApıCA.Domain.Events;

public class PaymentDeletedEvent : BaseEvent
{
    public PaymentDeletedEvent(Payment payment)
    {
        Payment = payment;
    }

    public Payment Payment { get; }
}
