using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using System;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    public ChatManager chatManager;

    public Text connectionStatusTxt;
    public InputField roomNameInp;
    public GameObject loginMenuObj, lobbyMenuObj, roomMenuObj, chatMenuObj;
    public RoomUiManager roomUIManager;
    string lastRoom;

    [Header("Room Management")]
    public Transform roomListContent;
    public RoomInfoData roomInfoDataPrefab;
    
    void SaatDiMenuLogin()
    {
        loginMenuObj.SetActive(true);
        lobbyMenuObj.SetActive(false);
        roomMenuObj.SetActive(false);
        if (chatMenuObj) chatMenuObj.SetActive(false);
    }

    void SaatDiMenuLobby()
    {
        loginMenuObj.SetActive(false);
        lobbyMenuObj.SetActive(true);
        roomMenuObj.SetActive(false);
        if (chatMenuObj) chatMenuObj.SetActive(true);
    }

    void SaatDiDalamRoom()
    {
        loginMenuObj.SetActive(false);
        lobbyMenuObj.SetActive(false);
        roomMenuObj.SetActive(true);
        if (chatMenuObj) chatMenuObj.SetActive(true);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        SaatDiMenuLogin();
    }

    // Update is called once per frame
    void Update()
    {
        connectionStatusTxt.text = PhotonNetwork.NetworkClientState.ToString();
    }

    public static void LoginWithId(string id)
    {
        PhotonNetwork.AuthValues = new AuthenticationValues
        {
            UserId = id
        };
        PhotonNetwork.ConnectUsingSettings();
    }

    ///<summary>
    /// diapnggil otomatis ketika status sudah "Connected to master"
    /// </summary>

    public override void OnConnectedToMaster()
    {
        SaatDiMenuLobby();
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.JoinLobby();
        PhotonNetwork.LocalPlayer.NickName = PhotonNetwork.AuthValues.UserId;
        if (chatManager.chatClient == null || chatManager.chatClient.State == Photon.Chat.ChatState.Disconnected) chatManager.Connect();
    }

    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions
        {
            MaxPlayers = 2,
            PublishUserId = true
        };

        PhotonNetwork.CreateRoom(roomNameInp.text, roomOptions);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(roomNameInp.text);
    }

    ///<summary>
    /// dipanggil otomatis ketika room berhasil dibuat
    /// </summary>

    public override void OnCreatedRoom()
    {
        base.OnCreatedRoom();
    }

    ///<summary>
    /// dipanggil otomatis ketika status sudah "Joined"
    /// </summary>

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        SaatDiDalamRoom();

        lastRoom = PhotonNetwork.CurrentRoom.Name;
        chatManager.SubscribeChannel(lastRoom);
    }

    ///<summary>
    ///Dipanggil otomatis ketika gagal join room
    /// </summary>

    public override void OnLeftRoom()
    {
        print("OnLeftRoom!");
        SaatDiMenuLobby();

        chatManager.UnsubscribeChannel(lastRoom);
    }

    ///<summary>
    /// dipanggil otomatis ketika gagal join room
    /// </summary>

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.LogError("OnJoinedRoomFailed! \n" + message);
    }

    ///<summary>
    /// Dipanggil otomatis ketika Disconnect / putus koneksi
    /// </summary>

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.LogError("Disconnected karena: " + cause.ToString());
        SaatDiMenuLogin();
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {

        ClearRoom();
        foreach(RoomInfo roomInfo in roomList)
        {
        if (roomInfo.PlayerCount == roomInfo.MaxPlayers) continue;

                RoomInfoData spawnedRoom = Instantiate(roomInfoDataPrefab, roomListContent);
                spawnedRoom.Setup(roomInfo);
        }
    }

    private void ClearRoom()
    {
        for(int i = 0; i < roomListContent.childCount; i++)
        {
            Destroy(roomListContent.GetChild(i).gameObject);
        }
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        roomUIManager.OnPlayerEnteredRoom(newPlayer);
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        roomUIManager.OnPlayerLeftRoom(otherPlayer);
    }

    public void Keluar()
    {
        Application.Quit();
    }
}
