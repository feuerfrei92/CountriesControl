using CountriesControlData.Implementations;
using CountriesControlData.Interfaces;
using CountriesControlServices.Implementations;
using CountriesControlServices.Interfaces;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesControlUI
{
    static class Program
    {
        private static Container container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(container.GetInstance<MainForm>());
        }

        private static void Bootstrap()
        {
            container = new Container();

            container.Options.PropertySelectionBehavior = new ImportPropertySelectionBehavior();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            container.Register<ICountryRepository, CountryRepository>(Lifestyle.Singleton);
            container.Register<ICountryService, CountryService>(Lifestyle.Singleton);
            container.Register<MainForm>(Lifestyle.Singleton);

            container.Verify();
        }
    }
}
