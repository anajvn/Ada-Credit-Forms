namespace TesteForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                Application.Run(new Intro());
            }
            catch (Exception ex)
            {
                Log(ex);
            }

            void Log(Exception ex)
            {
                string stackTrace = ex.StackTrace;
                File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Error.txt"), stackTrace); // path of file where stack trace will be stored.
            }
        }
    }
}