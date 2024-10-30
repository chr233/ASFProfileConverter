using System.Reflection;
using System.Runtime.Versioning;

namespace ASFProfileConverter
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
            Application.Run(new FrmMain());
        }

        /// <summary>
        /// ��ִ���ļ�
        /// </summary>
        private static readonly Assembly _assembly = Assembly.GetExecutingAssembly();

        /// <summary>
        /// �汾
        /// </summary>
        public static string? Version => _assembly.GetName().Version?.ToString();
        /// <summary>
        /// ���
        /// </summary>
        public static string? FrameworkName => _assembly.GetCustomAttribute<TargetFrameworkAttribute>()?.FrameworkDisplayName;
    }
}
