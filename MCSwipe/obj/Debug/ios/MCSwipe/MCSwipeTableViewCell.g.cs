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
	[Register("MCSwipeTableViewCell", true)]
	public unsafe partial class MCSwipeTableViewCell : global::MonoTouch.UIKit.UITableViewCell {
		[CompilerGenerated]
		const string selAnimationDuration = "animationDuration";
		static readonly IntPtr selAnimationDurationHandle = Selector.GetHandle ("animationDuration");
		[CompilerGenerated]
		const string selColor1 = "color1";
		static readonly IntPtr selColor1Handle = Selector.GetHandle ("color1");
		[CompilerGenerated]
		const string selColor2 = "color2";
		static readonly IntPtr selColor2Handle = Selector.GetHandle ("color2");
		[CompilerGenerated]
		const string selColor3 = "color3";
		static readonly IntPtr selColor3Handle = Selector.GetHandle ("color3");
		[CompilerGenerated]
		const string selColor4 = "color4";
		static readonly IntPtr selColor4Handle = Selector.GetHandle ("color4");
		[CompilerGenerated]
		const string selCompletionBlock1 = "completionBlock1";
		static readonly IntPtr selCompletionBlock1Handle = Selector.GetHandle ("completionBlock1");
		[CompilerGenerated]
		const string selCompletionBlock2 = "completionBlock2";
		static readonly IntPtr selCompletionBlock2Handle = Selector.GetHandle ("completionBlock2");
		[CompilerGenerated]
		const string selCompletionBlock3 = "completionBlock3";
		static readonly IntPtr selCompletionBlock3Handle = Selector.GetHandle ("completionBlock3");
		[CompilerGenerated]
		const string selCompletionBlock4 = "completionBlock4";
		static readonly IntPtr selCompletionBlock4Handle = Selector.GetHandle ("completionBlock4");
		[CompilerGenerated]
		const string selDamping = "damping";
		static readonly IntPtr selDampingHandle = Selector.GetHandle ("damping");
		[CompilerGenerated]
		const string selDefaultColor = "defaultColor";
		static readonly IntPtr selDefaultColorHandle = Selector.GetHandle ("defaultColor");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selFirstTrigger = "firstTrigger";
		static readonly IntPtr selFirstTriggerHandle = Selector.GetHandle ("firstTrigger");
		[CompilerGenerated]
		const string selInitWithStyleReuseIdentifier_ = "initWithStyle:reuseIdentifier:";
		static readonly IntPtr selInitWithStyleReuseIdentifier_Handle = Selector.GetHandle ("initWithStyle:reuseIdentifier:");
		[CompilerGenerated]
		const string selIsDragging = "isDragging";
		static readonly IntPtr selIsDraggingHandle = Selector.GetHandle ("isDragging");
		[CompilerGenerated]
		const string selModeForState1 = "modeForState1";
		static readonly IntPtr selModeForState1Handle = Selector.GetHandle ("modeForState1");
		[CompilerGenerated]
		const string selModeForState2 = "modeForState2";
		static readonly IntPtr selModeForState2Handle = Selector.GetHandle ("modeForState2");
		[CompilerGenerated]
		const string selModeForState3 = "modeForState3";
		static readonly IntPtr selModeForState3Handle = Selector.GetHandle ("modeForState3");
		[CompilerGenerated]
		const string selModeForState4 = "modeForState4";
		static readonly IntPtr selModeForState4Handle = Selector.GetHandle ("modeForState4");
		[CompilerGenerated]
		const string selSecondTrigger = "secondTrigger";
		static readonly IntPtr selSecondTriggerHandle = Selector.GetHandle ("secondTrigger");
		[CompilerGenerated]
		const string selSetAnimationDuration_ = "setAnimationDuration:";
		static readonly IntPtr selSetAnimationDuration_Handle = Selector.GetHandle ("setAnimationDuration:");
		[CompilerGenerated]
		const string selSetColor1_ = "setColor1:";
		static readonly IntPtr selSetColor1_Handle = Selector.GetHandle ("setColor1:");
		[CompilerGenerated]
		const string selSetColor2_ = "setColor2:";
		static readonly IntPtr selSetColor2_Handle = Selector.GetHandle ("setColor2:");
		[CompilerGenerated]
		const string selSetColor3_ = "setColor3:";
		static readonly IntPtr selSetColor3_Handle = Selector.GetHandle ("setColor3:");
		[CompilerGenerated]
		const string selSetColor4_ = "setColor4:";
		static readonly IntPtr selSetColor4_Handle = Selector.GetHandle ("setColor4:");
		[CompilerGenerated]
		const string selSetCompletionBlock1_ = "setCompletionBlock1:";
		static readonly IntPtr selSetCompletionBlock1_Handle = Selector.GetHandle ("setCompletionBlock1:");
		[CompilerGenerated]
		const string selSetCompletionBlock2_ = "setCompletionBlock2:";
		static readonly IntPtr selSetCompletionBlock2_Handle = Selector.GetHandle ("setCompletionBlock2:");
		[CompilerGenerated]
		const string selSetCompletionBlock3_ = "setCompletionBlock3:";
		static readonly IntPtr selSetCompletionBlock3_Handle = Selector.GetHandle ("setCompletionBlock3:");
		[CompilerGenerated]
		const string selSetCompletionBlock4_ = "setCompletionBlock4:";
		static readonly IntPtr selSetCompletionBlock4_Handle = Selector.GetHandle ("setCompletionBlock4:");
		[CompilerGenerated]
		const string selSetDamping_ = "setDamping:";
		static readonly IntPtr selSetDamping_Handle = Selector.GetHandle ("setDamping:");
		[CompilerGenerated]
		const string selSetDefaultColor_ = "setDefaultColor:";
		static readonly IntPtr selSetDefaultColor_Handle = Selector.GetHandle ("setDefaultColor:");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selSetFirstTrigger_ = "setFirstTrigger:";
		static readonly IntPtr selSetFirstTrigger_Handle = Selector.GetHandle ("setFirstTrigger:");
		[CompilerGenerated]
		const string selSetModeForState1_ = "setModeForState1:";
		static readonly IntPtr selSetModeForState1_Handle = Selector.GetHandle ("setModeForState1:");
		[CompilerGenerated]
		const string selSetModeForState2_ = "setModeForState2:";
		static readonly IntPtr selSetModeForState2_Handle = Selector.GetHandle ("setModeForState2:");
		[CompilerGenerated]
		const string selSetModeForState3_ = "setModeForState3:";
		static readonly IntPtr selSetModeForState3_Handle = Selector.GetHandle ("setModeForState3:");
		[CompilerGenerated]
		const string selSetModeForState4_ = "setModeForState4:";
		static readonly IntPtr selSetModeForState4_Handle = Selector.GetHandle ("setModeForState4:");
		[CompilerGenerated]
		const string selSetSecondTrigger_ = "setSecondTrigger:";
		static readonly IntPtr selSetSecondTrigger_Handle = Selector.GetHandle ("setSecondTrigger:");
		[CompilerGenerated]
		const string selSetShouldAnimateIcons_ = "setShouldAnimateIcons:";
		static readonly IntPtr selSetShouldAnimateIcons_Handle = Selector.GetHandle ("setShouldAnimateIcons:");
		[CompilerGenerated]
		const string selSetShouldDrag_ = "setShouldDrag:";
		static readonly IntPtr selSetShouldDrag_Handle = Selector.GetHandle ("setShouldDrag:");
		[CompilerGenerated]
		const string selSetVelocity_ = "setVelocity:";
		static readonly IntPtr selSetVelocity_Handle = Selector.GetHandle ("setVelocity:");
		[CompilerGenerated]
		const string selSetView1_ = "setView1:";
		static readonly IntPtr selSetView1_Handle = Selector.GetHandle ("setView1:");
		[CompilerGenerated]
		const string selSetView2_ = "setView2:";
		static readonly IntPtr selSetView2_Handle = Selector.GetHandle ("setView2:");
		[CompilerGenerated]
		const string selSetView3_ = "setView3:";
		static readonly IntPtr selSetView3_Handle = Selector.GetHandle ("setView3:");
		[CompilerGenerated]
		const string selSetView4_ = "setView4:";
		static readonly IntPtr selSetView4_Handle = Selector.GetHandle ("setView4:");
		[CompilerGenerated]
		const string selShouldAnimateIcons = "shouldAnimateIcons";
		static readonly IntPtr selShouldAnimateIconsHandle = Selector.GetHandle ("shouldAnimateIcons");
		[CompilerGenerated]
		const string selShouldDrag = "shouldDrag";
		static readonly IntPtr selShouldDragHandle = Selector.GetHandle ("shouldDrag");
		[CompilerGenerated]
		const string selSwipeToOriginWithCompletion_ = "swipeToOriginWithCompletion:";
		static readonly IntPtr selSwipeToOriginWithCompletion_Handle = Selector.GetHandle ("swipeToOriginWithCompletion:");
		[CompilerGenerated]
		const string selVelocity = "velocity";
		static readonly IntPtr selVelocityHandle = Selector.GetHandle ("velocity");
		[CompilerGenerated]
		const string selView1 = "view1";
		static readonly IntPtr selView1Handle = Selector.GetHandle ("view1");
		[CompilerGenerated]
		const string selView2 = "view2";
		static readonly IntPtr selView2Handle = Selector.GetHandle ("view2");
		[CompilerGenerated]
		const string selView3 = "view3";
		static readonly IntPtr selView3Handle = Selector.GetHandle ("view3");
		[CompilerGenerated]
		const string selView4 = "view4";
		static readonly IntPtr selView4Handle = Selector.GetHandle ("view4");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MCSwipeTableViewCell");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MCSwipeTableViewCell () : base (NSObjectFlag.Empty)
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
		public MCSwipeTableViewCell (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MCSwipeTableViewCell (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MCSwipeTableViewCell (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithStyle:reuseIdentifier:")]
		[CompilerGenerated]
		public MCSwipeTableViewCell (global::MonoTouch.UIKit.UITableViewCellStyle cellStyle, string reuseIdentifier)
			: base (NSObjectFlag.Empty)
		{
			if (reuseIdentifier == null)
				throw new ArgumentNullException ("reuseIdentifier");
			var nsreuseIdentifier = NSString.CreateNative (reuseIdentifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_int_IntPtr (this.Handle, selInitWithStyleReuseIdentifier_Handle, (int)cellStyle, nsreuseIdentifier), "initWithStyle:reuseIdentifier:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int_IntPtr (this.SuperHandle, selInitWithStyleReuseIdentifier_Handle, (int)cellStyle, nsreuseIdentifier), "initWithStyle:reuseIdentifier:");
			}
			NSString.ReleaseNative (nsreuseIdentifier);
			
		}
		
		[Export ("swipeToOriginWithCompletion:")]
		[CompilerGenerated]
		public unsafe virtual void SwipeToOriginWithCompletion ([BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDMCSwipeCompletionBlock))]MCSwipeCompletionBlock completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDMCSwipeCompletionBlock.Handler, completion);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSwipeToOriginWithCompletion_Handle, (IntPtr) block_ptr_completion);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSwipeToOriginWithCompletion_Handle, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Double AnimationDuration {
			[Export ("animationDuration")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, selAnimationDurationHandle);
				} else {
					return ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selAnimationDurationHandle);
				}
			}
			
			[Export ("setAnimationDuration:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, selSetAnimationDuration_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetAnimationDuration_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Color1_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor Color1 {
			[Export ("color1", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selColor1Handle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selColor1Handle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Color1_var = ret;
				return ret;
			}
			
			[Export ("setColor1:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetColor1_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetColor1_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Color1_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Color2_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor Color2 {
			[Export ("color2", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selColor2Handle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selColor2Handle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Color2_var = ret;
				return ret;
			}
			
			[Export ("setColor2:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetColor2_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetColor2_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Color2_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Color3_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor Color3 {
			[Export ("color3", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selColor3Handle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selColor3Handle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Color3_var = ret;
				return ret;
			}
			
			[Export ("setColor3:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetColor3_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetColor3_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Color3_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Color4_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor Color4 {
			[Export ("color4", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selColor4Handle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selColor4Handle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Color4_var = ret;
				return ret;
			}
			
			[Export ("setColor4:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetColor4_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetColor4_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Color4_var = value;
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual MCSwipeCompletionBlock CompletionBlock1 {
			[Export ("completionBlock1", ArgumentSemantic.Copy)]
			get {
				BlockLiteral *ret;
				if (IsDirectBinding) {
					ret = (BlockLiteral *)ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selCompletionBlock1Handle);
				} else {
					ret = (BlockLiteral *)ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCompletionBlock1Handle);
				}
				if (ret == null)
					return null;
				return (MCSwipeCompletionBlock) (ret->Target);
			}
			
			[Export ("setCompletionBlock1:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDMCSwipeCompletionBlock.Handler, value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCompletionBlock1_Handle, (IntPtr) block_ptr_value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCompletionBlock1_Handle, (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual MCSwipeCompletionBlock CompletionBlock2 {
			[Export ("completionBlock2", ArgumentSemantic.Copy)]
			get {
				BlockLiteral *ret;
				if (IsDirectBinding) {
					ret = (BlockLiteral *)ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selCompletionBlock2Handle);
				} else {
					ret = (BlockLiteral *)ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCompletionBlock2Handle);
				}
				if (ret == null)
					return null;
				return (MCSwipeCompletionBlock) (ret->Target);
			}
			
			[Export ("setCompletionBlock2:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDMCSwipeCompletionBlock.Handler, value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCompletionBlock2_Handle, (IntPtr) block_ptr_value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCompletionBlock2_Handle, (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual MCSwipeCompletionBlock CompletionBlock3 {
			[Export ("completionBlock3", ArgumentSemantic.Copy)]
			get {
				BlockLiteral *ret;
				if (IsDirectBinding) {
					ret = (BlockLiteral *)ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selCompletionBlock3Handle);
				} else {
					ret = (BlockLiteral *)ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCompletionBlock3Handle);
				}
				if (ret == null)
					return null;
				return (MCSwipeCompletionBlock) (ret->Target);
			}
			
			[Export ("setCompletionBlock3:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDMCSwipeCompletionBlock.Handler, value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCompletionBlock3_Handle, (IntPtr) block_ptr_value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCompletionBlock3_Handle, (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual MCSwipeCompletionBlock CompletionBlock4 {
			[Export ("completionBlock4", ArgumentSemantic.Copy)]
			get {
				BlockLiteral *ret;
				if (IsDirectBinding) {
					ret = (BlockLiteral *)ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selCompletionBlock4Handle);
				} else {
					ret = (BlockLiteral *)ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCompletionBlock4Handle);
				}
				if (ret == null)
					return null;
				return (MCSwipeCompletionBlock) (ret->Target);
			}
			
			[Export ("setCompletionBlock4:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDMCSwipeCompletionBlock.Handler, value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCompletionBlock4_Handle, (IntPtr) block_ptr_value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCompletionBlock4_Handle, (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual float Damping {
			[Export ("damping")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, selDampingHandle);
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, selDampingHandle);
				}
			}
			
			[Export ("setDamping:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, selSetDamping_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetDamping_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_DefaultColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor DefaultColor {
			[Export ("defaultColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selDefaultColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDefaultColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DefaultColor_var = ret;
				return ret;
			}
			
			[Export ("setDefaultColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDefaultColor_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDefaultColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_DefaultColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual MCSwipeTableViewCellDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				MCSwipeTableViewCellDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MCSwipeTableViewCellDelegate> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<MCSwipeTableViewCellDelegate> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool Dragging {
			[Export ("isDragging")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selIsDraggingHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDraggingHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float FirstTrigger {
			[Export ("firstTrigger")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, selFirstTriggerHandle);
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, selFirstTriggerHandle);
				}
			}
			
			[Export ("setFirstTrigger:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, selSetFirstTrigger_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetFirstTrigger_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MCCellMode ModeForState1 {
			[Export ("modeForState1")]
			get {
				if (IsDirectBinding) {
					return (MCCellMode) ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, selModeForState1Handle);
				} else {
					return (MCCellMode) ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selModeForState1Handle);
				}
			}
			
			[Export ("setModeForState1:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetModeForState1_Handle, (UInt32)value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetModeForState1_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MCCellMode ModeForState2 {
			[Export ("modeForState2")]
			get {
				if (IsDirectBinding) {
					return (MCCellMode) ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, selModeForState2Handle);
				} else {
					return (MCCellMode) ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selModeForState2Handle);
				}
			}
			
			[Export ("setModeForState2:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetModeForState2_Handle, (UInt32)value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetModeForState2_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MCCellMode ModeForState3 {
			[Export ("modeForState3")]
			get {
				if (IsDirectBinding) {
					return (MCCellMode) ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, selModeForState3Handle);
				} else {
					return (MCCellMode) ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selModeForState3Handle);
				}
			}
			
			[Export ("setModeForState3:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetModeForState3_Handle, (UInt32)value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetModeForState3_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MCCellMode ModeForState4 {
			[Export ("modeForState4")]
			get {
				if (IsDirectBinding) {
					return (MCCellMode) ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, selModeForState4Handle);
				} else {
					return (MCCellMode) ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selModeForState4Handle);
				}
			}
			
			[Export ("setModeForState4:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetModeForState4_Handle, (UInt32)value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetModeForState4_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float SecondTrigger {
			[Export ("secondTrigger")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, selSecondTriggerHandle);
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, selSecondTriggerHandle);
				}
			}
			
			[Export ("setSecondTrigger:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, selSetSecondTrigger_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetSecondTrigger_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldAnimateIcons {
			[Export ("shouldAnimateIcons")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selShouldAnimateIconsHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldAnimateIconsHandle);
				}
			}
			
			[Export ("setShouldAnimateIcons:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldAnimateIcons_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShouldAnimateIcons_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldDrag {
			[Export ("shouldDrag")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selShouldDragHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldDragHandle);
				}
			}
			
			[Export ("setShouldDrag:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldDrag_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShouldDrag_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float Velocity {
			[Export ("velocity")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, selVelocityHandle);
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, selVelocityHandle);
				}
			}
			
			[Export ("setVelocity:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, selSetVelocity_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetVelocity_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_View1_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView View1 {
			[Export ("view1", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selView1Handle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selView1Handle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_View1_var = ret;
				return ret;
			}
			
			[Export ("setView1:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetView1_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetView1_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_View1_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_View2_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView View2 {
			[Export ("view2", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selView2Handle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selView2Handle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_View2_var = ret;
				return ret;
			}
			
			[Export ("setView2:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetView2_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetView2_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_View2_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_View3_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView View3 {
			[Export ("view3", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selView3Handle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selView3Handle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_View3_var = ret;
				return ret;
			}
			
			[Export ("setView3:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetView3_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetView3_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_View3_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_View4_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView View4 {
			[Export ("view4", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selView4Handle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selView4Handle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_View4_var = ret;
				return ret;
			}
			
			[Export ("setView4:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetView4_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetView4_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_View4_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Color1_var = null;
				__mt_Color2_var = null;
				__mt_Color3_var = null;
				__mt_Color4_var = null;
				__mt_DefaultColor_var = null;
				__mt_Delegate_var = null;
				__mt_View1_var = null;
				__mt_View2_var = null;
				__mt_View3_var = null;
				__mt_View4_var = null;
			}
		}
	} /* class MCSwipeTableViewCell */
	public delegate void MCSwipeCompletionBlock (MCSwipeTableViewCell cell, MCCellState state, MCCellMode mode);
}
