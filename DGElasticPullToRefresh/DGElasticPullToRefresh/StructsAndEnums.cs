using System;

namespace DGElasticPullToRefresh
{
	public enum DGElasticPullToRefreshState : int /* nint */ {
		Stoped = 0,
		DGElasticPullToRefreshDragging,
		AnimatingBounce,
		Loading,
		AnimatingToStopped
	}
}

