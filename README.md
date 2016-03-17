## DGElasticPullToRefresh-Xamarin.iOS ##

DGElasticPullToRefresh-Xamarin.iOS is a binding project for [DGElasticPullToRefresh](https://github.com/gontovnik/DGElasticPullToRefresh) by [gontovnik](https://github.com/gontovnik) 


## How to use ##
	
There are two projects one for creating static lib and another for binding dll.

To generate binding dll open DGElasticPullToRefresh.sln and build. You will get dll in bin folder.

Now you can add dll as a reference in any xamarin.iOS project and use it as shown below.

	DGElasticPullToRefreshLoadingViewCircle loadingView = new DGElasticPullToRefreshLoadingViewCircle ();

	loadingView.TintColor = UIColor.White;

	TableView.Dg_addPullToRefreshWithActionHandler (async () => {
	// your code 
	}, loadingView);

	TableView.Dg_setPullToRefreshBackgroundColor(UIColor.White);

	TableView.Dg_setPullToRefreshFillColor(UIColor.Black);


## How it looks ##

![](https://github.com/nikhilgohil11/DGElasticPullToRefresh-Xamarin.iOS/blob/master/DGElasticPullToRefreshPreview1.gif)
![](https://github.com/nikhilgohil11/DGElasticPullToRefresh-Xamarin.iOS/blob/master/DGElasticPullToRefreshPreview2.gif)

## Lincense ##

[MIT License] (http://nikhilgohil11.mit-license.org/ "MIT License")
