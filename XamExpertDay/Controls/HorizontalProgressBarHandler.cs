using Microsoft.Maui;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamExpertDay.Controls
{
	partial class HorizontalProgressBarHandler
	{
		public static PropertyMapper<HorizontalProgressBar, HorizontalProgressBarHandler> HorizontalProgressBarMapper =
			new(ViewHandler.ViewMapper)
			{
				[nameof(HorizontalProgressBar.TrackColor)] = MapTrackColor,
				[nameof(HorizontalProgressBar.Progress)] = MapProgress,
				[nameof(HorizontalProgressBar.ProgressColor)] = MapProgressColor
			};

		public HorizontalProgressBarHandler() :
			base(HorizontalProgressBarMapper)
		{

		}

		public HorizontalProgressBarHandler(PropertyMapper mapper)
			: base(mapper)
		{

		}
	}
}
