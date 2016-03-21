// (c) Copyright HutongGames, LLC 2010-2016. All rights reserved.

using System;
using UnityEngine;

using UnityEngine.Networking;

using UnityStandardAssets.Network;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Standard Assets Networking")]
	[Tooltip("Causes the Server to switch back to the Lobby Scene.")]
	public class SanServerReturnToLobby : FsmStateAction
	{
		public override void OnEnter()
		{
			LobbyManager.s_Singleton.ServerReturnToLobby();
			Finish();
		}
	}
}

