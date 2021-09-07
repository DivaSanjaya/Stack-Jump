using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public bool obstacle;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (!obstacle)
        {
            if (collision.gameObject.tag == "ground")
            {
                Destroy(collision.gameObject);
            }
        }
        else
        {
            if (collision.gameObject.tag == "obstacle")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
