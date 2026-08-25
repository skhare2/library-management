namespace NEALibrary
{
    internal static class Program
    {
        /// <summary>
        public static User user;
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
            //Application.Run(new RemoveCopy()); 
            //Application.Run(new LibrarianForm());
        }
    }
}