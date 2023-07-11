namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            GC.Collect();

            User user = new User();
            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                user.Dispose();
            }
        }
    }
}