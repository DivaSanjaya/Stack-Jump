using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using System;

public class RoomUiManager : MonoBehaviourPunCallbacks
{
    public Text roomNameTxt;
    public Transform playerList;
    public PlayerData playerDataPrefab;

    public GameObject startBtnObj;

    ///<summary>
    /// void OnEnabled() akan otomatis dijalankan ketika gameObject di setActive(true);
    /// </summary>

    private void OnEnable()
    {
        roomNameTxt.text = PhotonNetwork.CurrentRoom.Name;
        RefreshPlayerList();
    }

    private void RefreshPlayerList()
    {
        ClearPlayerList();

        foreach(Player player in PhotonNetwork.CurrentRoom.Players.Values)
        {
            addPlayerList(player.UserId);
        }
    }

    private void addPlayerList(string playerName)
    {
        PlayerData spawnedPlayerData = Instantiate(playerDataPrefab, playerList);
        spawnedPlayerData.playerNameTxt.text = playerName;
    }

    private void ClearPlayerList()
    {
        for(int i=0; i < playerList.childCount; i++)
        {
            Destroy(playerList.GetChild(i).gameObject);
        }
    }

    ///<summary>
    /// Jika belum leave room, maka tidak diperbolehkan membuat room atau join room
    /// </summary>
    
    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }

    public void StartGame()
    {
        PhotonNetwork.LoadLevel("Game");
    }

    public void OnPlayerEnteredRoom(Player newPlayer)
    {
        addPlayerList(newPlayer.UserId);

        bool roomFull = PhotonNetwork.PlayerList.Length >= PhotonNetwork.CurrentRoom.MaxPlayers;
        startBtnObj.SetActive(roomFull);
    }

    public void OnPlayerLeftRoom(Player otherPlayer)
    {
        RefreshPlayerList();
        bool roomFull = PhotonNetwork.PlayerList.Length >= PhotonNetwork.CurrentRoom.MaxPlayers;
        startBtnObj.SetActive(roomFull);
    }
}
