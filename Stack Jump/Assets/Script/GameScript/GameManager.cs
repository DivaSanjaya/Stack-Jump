using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
    public Text scoreTxt, bonusTxt, countTxt;

    public Camera MainCamera2;

    public GameObject gameoveUI;
    public bool gameover=false;
    private int score=0,bonusScore=0;
    public static GameManager instance;

    public float offset, random;

    public playerControl player1, player2;
    public spawner spaw1, spaw2;

    public Coroutine spawnObjCor;
    public Animator anim,countAnim;

    public Canvas canvas;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        
        //PhotonNetwork.LocalPlayer; //ini player ku
        //PhotonNetwork.PlayerList;//dapetin semua player di room
        //photonView.TransferOwnership(); set owner

        // flow:
        // dapetin list player 
        // kalo player[0] = localplayer
        // player1 transferowner ke localplayer
        

        spawnObjCor = StartCoroutine(spawnObject());
    }

    // Update is called once per frame
    void Update()
    {
        if(player1.isDead==true && player2.isDead == true)
        {
            if (gameover == true && Input.GetMouseButtonDown(0))
            {
                if (player1.photonView.IsMine)
                {
                    player1.photonView.RPC("Retry", RpcTarget.All);
                }
                else
                {
                    player2.photonView.RPC("Retry", RpcTarget.All);
                }
            }
        }
    }

    

    public void gameScore()
    {
        if (gameover)
        {
            return;
        }
        else
        {
            score++;
            score += bonusScore;
            scoreTxt.text="Score: "+score.ToString();
            print("Score: " + score + "bonus: " + bonusScore);
        }
    }

    public void bonusGameScore()
    {
        if (gameover)
        {
            return;
        }
        else
        {
            bonusScore++;
            bonusTxt.text = "+" + bonusScore.ToString();
            anim.Play("3DAnimation");
        }
    }
    public void resetBonus()
    {
        if (gameover)
        {
            return;
        }
        else
        {
            bonusScore = 0;
        }
    }

    public void Lose()
    {
        gameoveUI.SetActive(true);
        gameover = true;
    }

    public IEnumerator spawnObject()
    {
        var players = PhotonNetwork.PlayerList;
        player1.photonView.TransferOwnership(players[0]);
        player2.photonView.TransferOwnership(players[1]);
        PhotonNetwork.LocalPlayer.SetCustomProperties(new ExitGames.Client.Photon.Hashtable
        {
            {"Ready", true}
        });
        if (players[0] == PhotonNetwork.LocalPlayer)
        {
            //player1.photonView.TransferOwnership(PhotonNetwork.LocalPlayer);
            //player2.photonView.TransferOwnership(players[1]);

        }
        else
        {
            Rect temprec = player2.cs.cam.rect;
            player2.cs.cam.rect = player1.cs.cam.rect;
            player1.cs.cam.rect = temprec;
            player1.cs.cam.depth = 2;
            canvas.worldCamera = MainCamera2;
            
            //cameraScript tempcs = player2.cs;
            //player2.cs = player1.cs;
            //player1.cs = tempcs;

            //player2.photonView.TransferOwnership(players[0]);
            //player1.photonView.TransferOwnership(PhotonNetwork.LocalPlayer);
        }

        object rawPlayer1Ready, rawPlayer2Ready;
        bool player1Ready=false, player2Ready=false;
        while(!player1Ready || !player2Ready)
        {
            if (players[0].CustomProperties.TryGetValue("Ready", out rawPlayer1Ready))
            {
                player1Ready = (bool)rawPlayer1Ready;
            }
            if (players[1].CustomProperties.TryGetValue("Ready", out rawPlayer2Ready))
            {
                player2Ready = (bool)rawPlayer2Ready;
            }
            yield return new WaitForEndOfFrame();
        }

        countTxt.text = "3";
        yield return new WaitForSeconds(1f);

        countTxt.text = "2";
        yield return new WaitForSeconds(1f);

        countTxt.text = "1";
        yield return new WaitForSeconds(1f);

        countTxt.transform.parent.gameObject.SetActive(false);
        //yield return new WaitForSeconds(1f);

        while (true)
        {
            random = Random.Range(0, 100f);
            
            Vector2 spawnPosition = transform.position;

            if (random<=50)
            {
                offset = offset * -1;
            }
            else
            {
                offset = offset * 1;
            }

            if (players[0].IsMasterClient && players[0] == PhotonNetwork.LocalPlayer)
            {
                player1.photonView.RPC("SpawnObstacleCmd", RpcTarget.AllViaServer, offset);
            }else if(players[1].IsMasterClient && players[1] == PhotonNetwork.LocalPlayer)
            {
                player2.photonView.RPC("SpawnObstacleCmd", RpcTarget.AllViaServer, offset);
            }

            
            //spawnPosition.x += offset * (Random.Range(0, 100f) <= 50 ? -1 : 1);
            //Instantiate(obstacles, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(2f);

        }
    }

    public void SpawnObstacle(float offset)
    {
        //kalo player1 = !ismine yang di stop spawn di player2
        if (player1.isDead == false)
        {
            spaw1.Spawn(offset);
        }
        

        if (player2.isDead == false )
        {
            spaw2.Spawn(offset);
           
        }
        
    }

    public void Keluar()
    {
        Application.Quit();
    }

}
