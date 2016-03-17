namespace DGElasticPullToRefreshStatic {

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
		[Export ("pullToRefreshView", ArgumentSemantic.Retain)]
		DGElasticPullToRefreshView PullToRefreshView { get; set; }

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
