namespace SOLID.DependencyInversionPrinciple;

public class ViolatePrinciple
{
    public class UserController
    {
        private Database database;
        public UserController()
        {
            this.database = new Database();
        }
        // ...
    }
}
