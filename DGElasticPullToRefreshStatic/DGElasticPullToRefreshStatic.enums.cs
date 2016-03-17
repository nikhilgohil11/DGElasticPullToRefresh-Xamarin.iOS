namespace DGElasticPullToRefreshStatic {

	[Native]
	public enum DGElasticPullToRefreshState : int /* nint */ {
		Stoped = 0,
		DGElasticPullToRefreshDragging,
		AnimatingBounce,
		Loading,
		AnimatingToStopped
	}
}
