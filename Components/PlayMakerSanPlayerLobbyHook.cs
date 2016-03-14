// (c) Copyright HutongGames, LLC 2010-2016. All rights reserved.
// this script is used on the 'PlayMaker LobbyManager' Prefab

using UnityEngine;
using System.Collections;
using UnityEngine.Networking;


public class PlayMakerSanPlayerLobbyHook : UnityStandardAssets.Network.LobbyHook  {

	public bool debug = false;

	 
	public override void OnLobbyServerSceneLoadedForPlayer(NetworkManager manager, GameObject lobbyPlayer, GameObject gamePlayer)
	{
		if (debug) Debug.Log("PlayMakerSanPlayerLobbyHook OnLobbyServerSceneLoadedForPlayer lobbyPlayer:"+lobbyPlayer+" gamePlayer:"+gamePlayer,this);

		if (lobbyPlayer == null)
			return;

		UnityStandardAssets.Network.LobbyPlayer lp = lobbyPlayer.GetComponent<UnityStandardAssets.Network.LobbyPlayer>();

		if(lp != null)
		{
			PlayMakerSanGameManager.AddPlayer(gamePlayer,lp);
		}
	}
}