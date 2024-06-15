namespace SOLID.SingleResponsibilityPrinciple;

/// <summary>
/// This class violate single reponsibility priciple because of validate email method and save user to database.
/// as we say, a class should only has one reason to change and has one responsibility.
/// </summary>
public class BasedOnPrinciple
{
    public class UserCreatorViolatedPrinciple
    {
        public void CreateUser(string username, string email, string password)
        {
            // Validation logic
            if (!ValidateEmail(email))
            {
                throw new ArgumentException("Invalid email format.");
            }
            // Business rules
            // Database persistence
            SaveUserToDatabase(username, email, password);
        }
        private bool ValidateEmail(string email)
        {
            // Validation logic
            return true;
        }
        private void SaveUserToDatabase(string username, string email, string password)
        {
            // Database persistence logic
        }
    }
}
