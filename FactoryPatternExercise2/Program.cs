namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use?");
            string response = Console.ReadLine();
            IDataAccess data = DataAccessFactory.GetDataAccesType(response);
            data.LoadData();
            data.SaveData();
        }
    }
}
