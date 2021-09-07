using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class spawner : MonoBehaviour
{
 
    public bool hidup = true;

    public GameObject obstacles, boxNewPos;
    
    public void Spawn(float offset)
    {
        Vector2 spawnPosition = transform.position;

        spawnPosition.x += offset;
        
        //spawnPosition.x += offset * (Random.Range(0, 100f) <= 50 ? -1 : 1

        boxNewPos = Instantiate(obstacles, spawnPosition, Quaternion.identity);
    }


}
