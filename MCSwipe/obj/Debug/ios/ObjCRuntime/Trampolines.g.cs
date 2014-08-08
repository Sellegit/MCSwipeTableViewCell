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

namespace MonoTouch.ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DMCSwipeCompletionBlock (IntPtr block, IntPtr cell, global::MCSwipe.MCCellState state, global::MCSwipe.MCCellMode mode);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMCSwipeCompletionBlock {
			static internal readonly DMCSwipeCompletionBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMCSwipeCompletionBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr cell, global::MCSwipe.MCCellState state, global::MCSwipe.MCCellMode mode) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MCSwipe.MCSwipeCompletionBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<MCSwipe.MCSwipeTableViewCell> (cell), state, mode);
			}
		} /* class SDMCSwipeCompletionBlock */
		
		internal class NIDMCSwipeCompletionBlock {
			IntPtr blockPtr;
			DMCSwipeCompletionBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMCSwipeCompletionBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMCSwipeCompletionBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMCSwipeCompletionBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::MCSwipe.MCSwipeCompletionBlock Create (IntPtr block)
			{
				return new NIDMCSwipeCompletionBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::MCSwipe.MCSwipeTableViewCell cell, global::MCSwipe.MCCellState state, global::MCSwipe.MCCellMode mode)
			{
				invoker (blockPtr, cell == null ? IntPtr.Zero : cell.Handle, state, mode);
			}
		} /* class NIDMCSwipeCompletionBlock */
	}
}
