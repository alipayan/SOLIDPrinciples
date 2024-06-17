namespace SOLID.InterfaceSegregationPrinciple;

public class BasedOnPrinciple
{
    public interface IOrder
    {
        void PlaceOrder();
        void CancelOrder();
        void UpdateOrder();
    }
    public interface IOrderProcessing
    {
        void CalculateTotal();
    }
    public interface IInvoiceGenerator
    {
        void GenerateInvoice();
    }
    public interface IEmailSender
    {
        void SendConfirmationEmail();
    }
    public interface ILabelPrinter
    {
        void PrintLabel();
    }
    // Implement only the necessary interfaces in client classes.
    public class OnlineOrder : IOrder, IOrderProcessing, IInvoiceGenerator, IEmailSender
    {
        // Implementation of required methods.
    }
    public class InStoreOrder : IOrder, IOrderProcessing, ILabelPrinter
    {
        // Implementation of required methods.
    }
}
