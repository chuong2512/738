// Copyright (C) 2017-2020 gamevanilla. All rights reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement,
// a copy of which is available at http://unity3d.com/company/legal/as_terms.

using UnityEngine;
using UnityEngine.Advertisements;

using GameVanilla.Game.Common;
using GameVanilla.Game.Popups;
using GameVanilla.Game.Scenes;

namespace GameVanilla.Game.UI
{
	/// <summary>
	/// The rewarded advertisement button that is present in the level scene.
	/// </summary>
	public class RewardedAdButton : MonoBehaviour
	{
		private const string PlacementId = "rewardedVideo";

		private void Start()
		{
		
			var gameConfig = PuzzleMatchManager.instance.gameConfig;

			var gameId = "1234567";
#if UNITY_IOS
	            gameId = gameConfig.adsGameIdIos;
#elif UNITY_ANDROID
	            gameId = gameConfig.adsGameIdAndroid;
#endif
			}

		private void OnDestroy()
		{
		}

		public void ShowRewardedAd()
		{
		}
		
		public void OnUnityAdsDidError(string message)
		{
			// Log the error.
		}

		public void OnUnityAdsDidStart(string placementId)
		{
			// Optional actions to take when the end-users triggers an ad.
		}
	}
}
