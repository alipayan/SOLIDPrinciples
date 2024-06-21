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
        public void CalculateTotal()
        {
            throw new NotImplementedException();
        }

        public void CancelOrder()
        {
            throw new NotImplementedException();
        }

        public void GenerateInvoice()
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder()
        {
            throw new NotImplementedException();
        }

        public void SendConfirmationEmail()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder()
        {
            throw new NotImplementedException();
        }
    }
    public class InStoreOrder : IOrder, IOrderProcessing, ILabelPrinter
    {
        public void CalculateTotal()
        {
            throw new NotImplementedException();
        }

        // Implementation of required methods.
        public void CancelOrder()
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder()
        {
            throw new NotImplementedException();
        }

        public void PrintLabel()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder()
        {
            throw new NotImplementedException();
        }
    }
}
