using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace MCSwipe
{
	public enum MCCellState : uint {
		None = 0,
		One = 1,
		Two = 2,
		Three = 3,
		Four = 4
	}

	public enum MCCellMode : uint {
		None = 0,
		Exit,
		Switch
	}
}

