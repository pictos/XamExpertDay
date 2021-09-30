using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using Microsoft.Maui.Graphics;
using System;

namespace XamExpertDay
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			count++;
			CounterLabel.Text = $"Current count: {count}";

			SemanticScreenReader.Announce(CounterLabel.Text);

			progressBar.Progress = Random.Shared.NextDouble();
			progressBar.TrackColor = Color.FromRgb(RandomColorValue(), RandomColorValue(), RandomColorValue());
			progressBar.ProgressColor = Color.FromRgb(RandomColorValue(), RandomColorValue(), RandomColorValue());



			static double RandomColorValue() => Random.Shared.NextDouble();
		}
	}
}
