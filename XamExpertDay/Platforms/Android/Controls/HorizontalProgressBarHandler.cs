using Android.Widget;
using Microsoft.Maui.Handlers;
using XamExpertDay.Platforms;

namespace XamExpertDay.Controls
{
	partial class HorizontalProgressBarHandler : ViewHandler<HorizontalProgressBar, ProgressBar>
	{
		const int PROGRESS_MAX_VALUE = 100;

		protected override ProgressBar CreateNativeView()
		{
			var nativeControl = new ProgressBar(Context, null, Android.Resource.Attribute.ProgressBarStyleHorizontal);
			return nativeControl;
		}

		protected override void ConnectHandler(ProgressBar nativeView)
		{
			nativeView.Max = PROGRESS_MAX_VALUE;
			nativeView.UpdateBackground(VirtualView.TrackColor);
			nativeView.UpdateProgressDrawable(VirtualView.ProgressColor);
			nativeView.UpdateProgressValue(VirtualView.Progress);
		}

		static void MapTrackColor(HorizontalProgressBarHandler handler, HorizontalProgressBar view)
		{
			handler?.NativeView.UpdateBackground(view.TrackColor);
		}

		static void MapProgress(HorizontalProgressBarHandler handler, HorizontalProgressBar view)
		{
			handler?.NativeView.UpdateProgressValue(view.Progress);
		}
		static void MapProgressColor(HorizontalProgressBarHandler handler, HorizontalProgressBar view)
		{
			handler?.NativeView.UpdateProgressDrawable(view.ProgressColor);
		}
	}
}
