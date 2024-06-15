namespace SOLID.InterfaceSegregationPrinciple;

public class ViolatePrinciple
{
    public interface IOrder
    {
        void PlaceOrder();
        void CancelOrder();
        void UpdateOrder();
        void CalculateTotal();
        void GenerateInvoice();
        void SendConfirmationEmail();
        void PrintLabel();
    }
    public class OnlineOrder : IOrder
    {
        // Implementation of all methods.
    }
    public class InStoreOrder : IOrder
    {
        // Implementation of all methods.
    }
}
