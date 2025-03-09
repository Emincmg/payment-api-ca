namespace PaymentApıCA.Domain.Events;

public class PaymentCompletedEvent : BaseEvent
{
    public PaymentCompletedEvent(Payment payment)
    {
        Payment = payment;
    }

    public Payment Payment { get; }
}
