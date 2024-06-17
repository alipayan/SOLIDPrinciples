namespace SOLID.SingleResponsibilityPrinciple;

/// <summary>
/// At this user creator class, we fetch out user validator functionality and saving user also.
/// this class now has only one responsibility.
/// </summary> 
public class ViolatePrinciple
{
    public class UserCreator(UserValidator validator, UserRepository repository)
    {
        private readonly UserValidator _validator = validator;
        private readonly UserRepository _repository = repository;

        public void CreateUser(string username, string email, string password)
        {
            // Validation logic
            if (!_validator.ValidateEmail(email))
            {
                throw new ArgumentException("Invalid email format.");
            }
            // Business rules
            // Database persistence
            _repository.SaveUser(username, email, password);
        }
    }
    public class UserValidator
    {
        public bool ValidateEmail(string email)
        {
            // Validation logic
            return true;
        }
    }
    public class UserRepository
    {
        public void SaveUser(string username, string email, string password)
        {
            // Database persistence logic
        }
    }
}
