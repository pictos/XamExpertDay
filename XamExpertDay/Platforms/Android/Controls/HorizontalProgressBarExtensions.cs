using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Widget;
using Microsoft.Maui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamExpertDay.Platforms
{
	static class HorizontalProgressBarExtensions
	{
		internal static void UpdateBackground(this ProgressBar nativeView, Microsoft.Maui.Graphics.Color color)
		{
			if (color is null)
				return;

			var drawable = GetHorizontalTrack(color.ToNative(), nativeView.Context);
			nativeView.Background = drawable;

			static Drawable GetHorizontalTrack(Android.Graphics.Color color, Context context)
			{
				var drawable = context.GetDrawable(Resource.Drawable.horizontal_track_bar) as GradientDrawable;
				drawable.SetColor(ColorStateList.ValueOf(color));
				return drawable;
			}
		}

		public static void UpdateProgressValue(this Android.Widget.ProgressBar nativeView, double progress)
		{
			nativeView.SetProgress(GetProgress(progress), true);

			static int GetProgress(double progress)
			{
				return Convert.ToInt32(
					Math.Floor(progress * 100)
				);
			}
		}

		public static void UpdateProgressDrawable(this Android.Widget.ProgressBar nativeView, Microsoft.Maui.Graphics.Color color)
		{
			if (color is null)
				return;

			nativeView.SetProgressDrawableTiled(GetHorizontalProgress(color.ToNative(), nativeView.Context));

			static Drawable GetHorizontalProgress(Android.Graphics.Color color, Context context)
			{
				var scale = context.GetDrawable(Resource.Drawable.horizontal_progress_bar) as ScaleDrawable;

				var drawable = scale.Drawable as GradientDrawable;
				drawable.SetColor(ColorStateList.ValueOf(color));

				return scale;
			}
		}
	}
}
