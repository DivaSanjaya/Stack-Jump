using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using Photon.Pun;
using Photon.Realtime;

public class PlayfabManager : MonoBehaviour
{
    public InputField emailInp, userInp, passInp;

    

    public void LoginBtn()
    {
        Login(userInp.text, passInp.text);
    }

    public void RegisterBtn()
    {
        Register(emailInp.text, userInp.text, passInp.text);
    }

    public void Login(string username, string password)
    {
        LoginWithPlayFabRequest request = new LoginWithPlayFabRequest();
        request.Username = username;
        request.Password = password;
        PlayFabClientAPI.LoginWithPlayFab(request,this.OnLoginSuccess, this.OnError);
    }

    public void Register(string email,string username, string password)
    {
        RegisterPlayFabUserRequest request = new RegisterPlayFabUserRequest();
        request.Email = email;
        request.Username = username;
        request.Password = password;
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);
    }

    public void OnLoginSuccess(LoginResult result)
    {
        Debug.LogError("Login Success");
        LoginPhotonWithId(userInp.text);
    }

    public void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        Debug.LogError("Register Success");
        LoginPhotonWithId(result.Username);
    }

    public void OnError(PlayFabError error)
    {
        Debug.LogError(error.ErrorMessage);
    }

    private void LoginPhotonWithId(string id)
    {

        PhotonNetwork.AuthValues = new AuthenticationValues
        {
            UserId = id,
            
        };

        PhotonNetwork.ConnectUsingSettings();

    }
}

