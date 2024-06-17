namespace SOLID.DependencyInversionPrinciple;

public class BasedOnPrinciple
{
    public interface IDataStorage
    {
        // Define the contract for data storage operations.
        void SaveData(string data);
        string RetrieveData();
    }
    public class Database : IDataStorage
    {
        public void SaveData(string data)
        {
            // Implementation for saving data to a database.
        }
        public string RetrieveData()
        {
            // Implementation for retrieving data from a database.
            return string.Empty;
        }
    }
    public class UserController
    {
        private IDataStorage dataStorage;
        public UserController(IDataStorage dataStorage)
        {
            this.dataStorage = dataStorage;
        }
        // ...
    }
}
