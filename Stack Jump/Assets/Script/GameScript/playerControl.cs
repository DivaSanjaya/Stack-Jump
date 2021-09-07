using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System;
using UnityEngine.SceneManagement;

public class playerControl : MonoBehaviourPun, IPunObservable
{
    public Rigidbody2D chara;
    public float power;
    public bool isReady = false, isDead = false, trigger;
    public cameraScript cs;
    public int firstSpawn = 1;
    
   
    Collider2D tempcol;

    // Start is called before the first frame update
    void Start()
    {
        chara.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isReady == true && isDead == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (photonView.IsMine) {
                    Jump();
                }
            }
        }
        else if (isDead == true)
        {
            if (photonView.IsMine)
            {
                chara.constraints = RigidbodyConstraints2D.None;
                //GameManager.instance.StopCoroutine(GameManager.instance.spawnObjCor);
                GameManager.instance.Lose();
            }
            
        }
    }

    [PunRPC]
    public void Jump()
    {
        chara.velocity = new Vector2(0, power);
        isReady = false;
        trigger = false;
    }

    [PunRPC]
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    [PunRPC]
    public void SpawnObstacleCmd(float offset)
    {
        GameManager.instance.SpawnObstacle(offset);
    }

    [PunRPC]
    public void boxPos(float x, float y, float z)
    {
        if (PhotonNetwork.PlayerList[0] == PhotonNetwork.LocalPlayer)
        {
           
           
                GameManager.instance.spaw2.boxNewPos.transform.position = new Vector3(x, y, z);
                GameManager.instance.spaw2.boxNewPos.gameObject.GetComponentInParent<obstacleMove>().enabled = false;
                print("x: " + x + " y: " + y + " z: " + z);
            
            
        }
        else
        {
            if (GameManager.instance.spaw1.boxNewPos != null)
            {
                if(firstSpawn > 0)
                {
                    GameManager.instance.spaw1.boxNewPos.transform.position = new Vector3(x, y-0.91f, z);
                    GameManager.instance.spaw1.boxNewPos.gameObject.GetComponentInParent<obstacleMove>().enabled = false;
                    print("x2: " + x + " y2: " + y + " z2: " + z);
                }
                else
                {
                    GameManager.instance.spaw1.boxNewPos.transform.position = new Vector3(x, y, z);
                    GameManager.instance.spaw1.boxNewPos.gameObject.GetComponentInParent<obstacleMove>().enabled = false;
                    print("x2: " + x + " y2: " + y + " z2: " + z);
                }
               
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isReady = true;
        if (collision.gameObject.CompareTag("ground") == false)
        {
            Vector3 obstaclePos = collision.transform.position + new Vector3(0f, 0.6f, 0f);
            Debug.DrawLine(collision.contacts[0].point, obstaclePos, Color.red, 5f);
            if (trigger == false)
            {
              
                isDead = true;
                               
                collision.gameObject.GetComponent<obstacleMove>().enabled = false;
                if (photonView.IsMine)
                {
                    photonView.RPC("boxPos", RpcTarget.Others, collision.transform.position.x, collision.transform.position.y, collision.transform.position.z);
                }
                
                cs.target.SetActive(false);
            }
        }
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (tempcol ==null || tempcol != collision)
        {
            if(tempcol != null && tempcol.transform.position.x== collision.transform.position.x )
            {
                isDead = false;
                tempcol = collision;
                collision.gameObject.GetComponentInParent<obstacleMove>().enabled = false;
                if (photonView.IsMine)
                {
                    photonView.RPC("boxPos", RpcTarget.Others, collision.transform.position.x, collision.transform.position.y, collision.transform.position.z);
                }
                cs.target.transform.position += new Vector3(0f, 2f, 0f);
                GameManager.instance.bonusGameScore();
                GameManager.instance.gameScore();
            }else
            {
                isDead = false;
                tempcol = collision;
                collision.gameObject.GetComponentInParent<obstacleMove>().enabled = false;
                if (photonView.IsMine)
                {
                    photonView.RPC("boxPos", RpcTarget.Others, collision.transform.position.x, collision.transform.position.y, collision.transform.position.z);
                }
                cs.target.transform.position += new Vector3(0f, 2f, 0f);
                GameManager.instance.resetBonus();
                GameManager.instance.gameScore();
            }
             
        }

        trigger = true;
        Invoke("SwitchTrigger", 0.05f);

    }

    public void SwitchTrigger()
    {
        if (photonView.IsMine)
        {
            trigger = false;
        }
        else
        {
            trigger = true;
            
        }
           
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(isDead);
        }
        else
        {
            isDead= (bool) stream.ReceiveNext();
        }
    }
}
