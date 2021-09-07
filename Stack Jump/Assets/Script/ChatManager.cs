using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Chat;
using ExitGames.Client.Photon;


public class ChatManager : MonoBehaviour, IChatClientListener
{
    public Toggle channelToggle;
    public Text chatViewText;
    public Transform channelListContent, chatTextContent;
    public ChatClient chatClient;

    public string selectedChannel;

    // Start is called before the first frame update
    void Start()
    {
        selectedChannel = string.IsNullOrEmpty(selectedChannel) ? "Lobby" : selectedChannel;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.chatClient !=null)
        {
            this.chatClient.Service();
            if (chatClient.State == ChatState.Disconnected) Connect();
        }
    }

    public void Connect()
    {
        this.chatClient = new ChatClient(this);
        this.chatClient.Connect(PhotonNetwork.PhotonServerSettings.AppSettings.AppIdChat, "1.0", new Photon.Chat.AuthenticationValues(PhotonNetwork.LocalPlayer.UserId));
    }

    public void SubscribeChannel(InputField channelNameTxt)
    {
        SubscribeChannel(channelNameTxt.text);
    }

    public void SubscribeChannel(string channelName)
    {
        this.chatClient.Subscribe(channelName);
    }

    public void UnsubscribeChannel(InputField channelNameTxt)
    {
        this.chatClient.Unsubscribe(new string[] { channelNameTxt.text });
    }

    public void UnsubscribeChannel(Text channelNameTxt)
    {
        this.chatClient.Unsubscribe(new string[] { channelNameTxt.text });
    }
    public void UnsubscribeChannel(string channelName)
    {
        this.chatClient.Unsubscribe(new string[] { channelName });
    }

    public void SetSelectedChannel(Text channelSelectedTxt)
    {
        selectedChannel = channelSelectedTxt.text;
        RefreshMessageList();
    }
    public void SetSelectedChannel(string channelSelectedTxt)
    {
        selectedChannel = channelSelectedTxt;
        RefreshMessageList();
    }

    private void RefreshMessageList()
    {
        ChatChannel chatChannel;
        if(chatClient.TryGetChannel(selectedChannel,out chatChannel))
        {
            chatViewText.text = chatChannel.ToStringMessages();
        }
    }

    public void DestroyGameObject(GameObject obj)
    {
        Destroy(obj);
    }

    public void SendChatMessage(InputField msg)
    {
        this.chatClient.PublishMessage(selectedChannel, msg.text);
    }

    public void DebugReturn(DebugLevel level, string message)
    {
        if(level == DebugLevel.ERROR)
        {
            Debug.LogError(message);
        }
        else if(level == DebugLevel.WARNING)
        {
            Debug.LogError(message);
        }
        else
        {
            Debug.Log(message);
        }
    }
    
    public void OnChatStateChange(ChatState state)
    {
        print("OnChatStateChange " + state);
    }

    public void OnDisconnected()
    {
        print("OnDisconnected!");
    }

    public void OnConnected()
    {
        print("OnConnected");
        SubscribeChannel(selectedChannel);
    }

    public void OnGetMessages(string channelName, string[] senders, object[] messages)
    {
        RefreshMessageList();
    }

    public void OnPrivateMessage(string sender, object message, string channelName)
    {
        print("OnPrivateMessage!");
    }

    public void OnSubscribed(string[] channels, bool[] results)
    {
        foreach(string channelName in channels)
        {
            Toggle spawnedToggle = Instantiate(channelToggle, channelListContent);
            spawnedToggle.gameObject.SetActive(true);
            spawnedToggle.GetComponentInChildren<Text>().text = channelName;
            spawnedToggle.isOn = true;
            SetSelectedChannel(channelName);
        }
    }

    public void OnUnsubscribed(string[] channels)
    {
        print("OnUnsubscribed!");
        foreach(string channelName in channels)
        {
            foreach(Text txt in channelListContent.GetComponentsInChildren<Text>())
            {
                if (txt.text == channelName) Destroy(txt.transform.parent.gameObject);
            }
        }
    }

    public void OnStatusUpdate(string user, int status, bool gotMessage, object message)
    {
        print("OnStatusUpdate");
    }

    public void OnUserSubscribed(string channel, string user)
    {
        print("OnUserSubscribed!");
    }

    public void OnUserUnsubscribed(string channel, string user)
    {
        print("OnUserSubscribed!");
    }
}
