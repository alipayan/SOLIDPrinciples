namespace SOLID.DependencyInversionPrinciple;

public class ViolatePrinciple
{
    public class Database { }

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
