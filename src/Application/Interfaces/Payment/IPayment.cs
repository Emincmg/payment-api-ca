namespace PaymentApıCA.Application.Interfaces.Payment;

public interface IPayment :  IPaymentProcessor, IPaymentDecliner, IPaymentSuccessor
{
    int Id { get; set; }
    float Amount { get; set; }
    string Currency { get; set; }
    string Status { get; set; }
    DateTime? ConfirmedAt { get; set; }
    DateTime? DeclinedAt { get; set; }
    int Tries { get; set; }
    DateTime CreatedAt { get; set; }
    DateTime UpdatedAt { get; set; }
}
