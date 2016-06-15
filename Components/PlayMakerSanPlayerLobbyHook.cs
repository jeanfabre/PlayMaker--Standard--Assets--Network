// (c) Copyright HutongGames, LLC 2010-2016. All rights reserved.
// this script is used on the 'PlayMaker LobbyManager Proxy' Prefab

using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

using Prototype.NetworkLobby;

using HutongGames.PlayMaker;

public class PlayMakerSanPlayerLobbyHook : LobbyHook  {

	public bool debug = false;

	public override void OnLobbyServerSceneLoadedForPlayer(NetworkManager manager, GameObject lobbyPlayer, GameObject gamePlayer)
	{
		if (debug) Debug.Log("PlayMakerSanPlayerLobbyHook OnLobbyServerSceneLoadedForPlayer lobbyPlayer:"+lobbyPlayer+" gamePlayer:"+gamePlayer,this);

		if (lobbyPlayer == null)
			return;

		LobbyPlayer lp = lobbyPlayer.GetComponent<LobbyPlayer>();

		if(lp != null)
		{

			Debug.Log("Local Player name :"+lp.playerName+" Color:"+lp.playerColor);

			Fsm.EventData.StringData = lp.playerName;
			Fsm.EventData.ColorData = lp.playerColor;

			PlayMakerUtils.SendEventToGameObject (null, gamePlayer, "UNET / SAN / ON LOBBY SERVER SCENE LOADED FOR PLAYER");

		}


	}
}