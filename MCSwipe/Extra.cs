using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace MCSwipe
{
	public static class Colors {
		public static UIColor Green {
			get {
				return UIColor.FromRGB (85, 213, 80);
			}
		}

		public static UIColor Red {
			get {
				return UIColor.FromRGB (232, 61, 14);
			}
		}

		public static UIColor Yellow {
			get {
				return UIColor.FromRGB (254, 217, 56);
			}
		}

		public static UIColor Brown {
			get {
				return UIColor.FromRGB (206, 149, 98);
			}
		}
	}

	public static class Extra
	{
		public static void SetSwipeGestureWithView(this MCSwipeTableViewCell cell, UIImage Image, UIColor Color, MCCellMode Mode, MCCellState State, MCSwipeCompletionBlock Completion)
		{
			switch (State) {
			case MCCellState.One:
				cell.Color1 = Color;
				cell.View1 = ViewWithImage (Image);
				cell.ModeForState1 = Mode;
				cell.CompletionBlock1 = Completion;
				break;

			case MCCellState.Two:
				cell.Color2 = Color;
				cell.View2 = ViewWithImage (Image);
				cell.ModeForState2 = Mode;
				cell.CompletionBlock2 = Completion;
				break;

			case MCCellState.Three:
				cell.Color3 = Color;
				cell.View3 = ViewWithImage (Image);
				cell.ModeForState3 = Mode;
				cell.CompletionBlock3 = Completion;
				break;

			case MCCellState.Four:
				cell.Color4 = Color;
				cell.View4 = ViewWithImage (Image);
				cell.ModeForState4 = Mode;
				cell.CompletionBlock4 = Completion;
				break;
			}
		}

		private static UIView ViewWithImage(UIImage img) {
			UIImageView ImageView = new UIImageView (img);
			ImageView.ContentMode = UIViewContentMode.Center;
			return ImageView;
		}
	}
}

