// (c) Copyright HutongGames, LLC 2010-2016. All rights reserved.

using UnityEngine;
using System.Collections;

using Prototype.NetworkLobby;

/// <summary>
/// adds a PlayMakerSanPlayerLobbyHook component to the LobbyManager Prefab
/// This is preffered over duplicating the entire LobbyManager prefab, here we leave it completly untouched and so future updates will go smoother without the need for recreating
/// the PlayMaker counter part of the LobbyManager
/// </summary>
public class PlayMakerSanLobbyManagerProxy : MonoBehaviour {

	[Tooltip("The LobbyManager in the Scene. Don't drop the Prefab itself, only the instance within the Lobby Scene Hierarchy")]
	public LobbyManager lobbyManager;

	[Tooltip("If True, will output details over the activity. Turning it on when developing is recommanded")]
	public bool debug = false;


	PlayMakerSanPlayerLobbyHook _hook; 

	// Use this for initialization
	void Awake () {
	
		DontDestroyOnLoad (this.gameObject);

		if (lobbyManager.gameObject.GetComponent<PlayMakerSanPlayerLobbyHook> () == null) {
			_hook = lobbyManager.gameObject.AddComponent<PlayMakerSanPlayerLobbyHook> ();
			_hook.debug = this.debug;
		}

	}
}