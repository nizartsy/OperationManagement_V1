using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OperationManagement_UI.Core;
using OperationManagement_UI.ViewModel;
using IDataAdapter = OperationManagement_UI.Interface.IDataAdapter;

namespace OperationManagement_UI
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{

		private readonly IServiceProvider _serviceProvider;

		public App()
		{
			// Set up your dependency injection container
			IServiceCollection services = new ServiceCollection();

			// Register your services
			services.AddSingleton<MainWindowViewModel>(); // Example service registration
			services.AddSingleton<IDataAdapter, DataAdapter>(); // Example service registration

			// Build the service provider
			_serviceProvider = services.BuildServiceProvider();
		}

		protected override async void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			// Resolve MainWindowViewModel from the service provider
			var mainWindowViewModel = _serviceProvider.GetRequiredService<MainWindowViewModel>();

			// Create MainWindow and set its DataContext
			var mainWindow = new MainWindow()
			{
				DataContext = mainWindowViewModel
			};
			mainWindow.Show();

		}

		protected override async void OnExit(ExitEventArgs e)
		{
			base.OnExit(e);
		}
	}

}
