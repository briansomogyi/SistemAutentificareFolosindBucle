namespace SistemAutentificareFolosindBucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string userName = "Brian";
            const string password = "info_eco";
            do 
            {
                Console.WriteLine("Introduceti userul si parola");
                string userNameInput = Console.ReadLine();
                string passwordInput = Console.ReadLine();
                if (userName == userNameInput && password == passwordInput)
                {
                    Console.WriteLine($"Bine ai venit, {userName}");
                    break;
                }
                else
                {
                    Console.WriteLine("Autentificare esuata");
                }
            } while (true);
        }
    }
}