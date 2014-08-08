//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace MCSwipe {
	[Register("MCSwipeTableViewCellDelegate", true)]
	[Model]
	public unsafe partial class MCSwipeTableViewCellDelegate : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MCSwipeTableViewCellDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public MCSwipeTableViewCellDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MCSwipeTableViewCellDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MCSwipeTableViewCellDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("swipeTableViewCellDidEndSwiping:")]
		[CompilerGenerated]
		public virtual void DidEndSwiping (MCSwipeTableViewCell cell)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("swipeTableViewCellDidStartSwiping:")]
		[CompilerGenerated]
		public virtual void DidStartSwiping (MCSwipeTableViewCell cell)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("swipeTableViewCell:didSwipeWithPercentage:")]
		[CompilerGenerated]
		public virtual void DidSwipeWithPercentage (MCSwipeTableViewCell cell, float percentage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MCSwipeTableViewCellDelegate */
}
