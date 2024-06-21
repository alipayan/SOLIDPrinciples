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

        public void PrintLabel()
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
    public class InStoreOrder : IOrder
    {
        // Implementation of all methods.
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

        public void PrintLabel()
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
}
