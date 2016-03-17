using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using CoreAnimation;

namespace DGElasticPullToRefresh
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
	//


	// @interface DGElasticPullToRefreshLoadingView : UIView
	[BaseType (typeof (UIView))]
	interface DGElasticPullToRefreshLoadingView {

		// @property (nonatomic, strong) CAShapeLayer * maskLayer;
		[Export ("maskLayer", ArgumentSemantic.Retain)]
		CAShapeLayer MaskLayer { get; set; }

		// -(void)setPullProgress:(CGFloat)progress;
		[Export ("setPullProgress:")]
		void SetPullProgress (nfloat progress);

		// -(void)startAnimating;
		[Export ("startAnimating")]
		void StartAnimating ();

		// -(void)stopLoading;
		[Export ("stopLoading")]
		void StopLoading ();
	}

	// @interface DGElasticPullToRefreshLoadingViewCircle : DGElasticPullToRefreshLoadingView
	[BaseType (typeof (DGElasticPullToRefreshLoadingView))]
	interface DGElasticPullToRefreshLoadingViewCircle {

	}

	// @interface DGElasticPullToRefreshView : UIView
	[BaseType (typeof (UIView))]
	interface DGElasticPullToRefreshView {

		// @property (copy, nonatomic) void (^)() actionHandler;
		[Export ("actionHandler", ArgumentSemantic.Copy)]
		Action ActionHandler { get; set; }

		// @property (nonatomic, strong) DGElasticPullToRefreshLoadingView * loadingView;
		[Export ("loadingView", ArgumentSemantic.Retain)]
		DGElasticPullToRefreshLoadingView LoadingView { get; set; }

		// @property (assign, nonatomic) BOOL observing;
		[Export ("observing", ArgumentSemantic.UnsafeUnretained)]
		bool Observing { get; set; }

		// @property (nonatomic, strong) UIColor * fillColor;
		[Export ("fillColor", ArgumentSemantic.Retain)]
		UIColor FillColor { get; set; }

		// @property (assign, nonatomic) CGFloat waveMaxHeight;
		[Export ("waveMaxHeight", ArgumentSemantic.UnsafeUnretained)]
		nfloat WaveMaxHeight { get; set; }

		// @property (assign, nonatomic) CGFloat minOffsetToPull;
		[Export ("minOffsetToPull", ArgumentSemantic.UnsafeUnretained)]
		nfloat MinOffsetToPull { get; set; }

		// @property (assign, nonatomic) CGFloat loadingContentInset;
		[Export ("loadingContentInset", ArgumentSemantic.UnsafeUnretained)]
		nfloat LoadingContentInset { get; set; }

		// @property (assign, nonatomic) CGFloat loadingViewSize;
		[Export ("loadingViewSize", ArgumentSemantic.UnsafeUnretained)]
		nfloat LoadingViewSize { get; set; }

		// -(UIScrollView *)scrollView;
		[Export ("scrollView")]
		UIScrollView ScrollView ();

		// -(void)disassociateDisplayLink;
		[Export ("disassociateDisplayLink")]
		void DisassociateDisplayLink ();

		// -(void)stopLoading;
		[Export ("stopLoading")]
		void StopLoading ();
	}

	// @interface DGElasticPullToRefresh (UIScrollView)
	[Category]
	[BaseType (typeof (UIScrollView))]
	interface DGElasticPullToRefresh {

		// @property (nonatomic, strong) DGElasticPullToRefreshView * pullToRefreshView;
//		[Export ("pullToRefreshView", ArgumentSemantic.Retain)]
//		DGElasticPullToRefreshView PullToRefreshView { get; set; }

		// -(void)dg_addPullToRefreshWithActionHandler:(void (^)())actionHandler loadingView:(DGElasticPullToRefreshLoadingView *)loadingView;
		[Export ("dg_addPullToRefreshWithActionHandler:loadingView:")]
		void Dg_addPullToRefreshWithActionHandler (Action actionHandler, DGElasticPullToRefreshLoadingView loadingView);

		// -(void)dg_addPullToRefreshWithWaveMaxHeight:(CGFloat)waveMaxHeight minOffsetToPull:(CGFloat)minOffsetToPull loadingContentInset:(CGFloat)loadingContentInset loadingViewSize:(CGFloat)loadingViewSize actionHandler:(void (^)())actionHandler loadingView:(DGElasticPullToRefreshLoadingView *)loadingView;
		[Export ("dg_addPullToRefreshWithWaveMaxHeight:minOffsetToPull:loadingContentInset:loadingViewSize:actionHandler:loadingView:")]
		void Dg_addPullToRefreshWithWaveMaxHeight (nfloat waveMaxHeight, nfloat minOffsetToPull, nfloat loadingContentInset, nfloat loadingViewSize, Action actionHandler, DGElasticPullToRefreshLoadingView loadingView);

		// -(void)dg_removePullToRefresh;
		[Export ("dg_removePullToRefresh")]
		void Dg_removePullToRefresh ();

		// -(void)dg_setPullToRefreshBackgroundColor:(UIColor *)color;
		[Export ("dg_setPullToRefreshBackgroundColor:")]
		void Dg_setPullToRefreshBackgroundColor (UIColor color);

		// -(void)dg_setPullToRefreshFillColor:(UIColor *)color;
		[Export ("dg_setPullToRefreshFillColor:")]
		void Dg_setPullToRefreshFillColor (UIColor color);

		// -(void)dg_stopLoading;
		[Export ("dg_stopLoading")]
		void Dg_stopLoading ();
	}
}

