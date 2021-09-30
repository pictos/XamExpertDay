using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using XamExpertDay.Controls;

namespace XamExpertDay
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				})
				.ConfigureMauiHandlers(h =>
				{
					h.AddHandler(typeof(HorizontalProgressBar), typeof(HorizontalProgressBarHandler));
				});

			return builder.Build();
		}
	}
}