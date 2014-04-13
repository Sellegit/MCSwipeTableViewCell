using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace MCSwipe
{
	public enum MCSwipeTableViewCellState : uint {
		None = 0,
		One = 1,
		Two = 2,
		Three = 3,
		Four = 4
	}

	public enum MCSwipeTableViewCellMode : uint {
		None = 0,
		Exit,
		Switch
	}

	public enum MCSwipeCompletionBlock : uint {
		TableViewCellModeNone = 0,
		TableViewCellModeExit,
		TableViewCellModeSwitch
	}
}

