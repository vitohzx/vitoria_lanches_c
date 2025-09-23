namespace lanches_vitoria
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
            Application.Run(new Home());
        }

        public class DadosUser
        {

            public static int userId { get; set; } = 0;
            public static string userName { get; set; } = "";
            public static string userTipo { get; set; } = "cliente";

        }


    }
}