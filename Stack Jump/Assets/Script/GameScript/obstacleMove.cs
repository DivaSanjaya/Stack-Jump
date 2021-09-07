using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMove : MonoBehaviour
{
    public Rigidbody2D box;
    public float stopPos;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        box.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Stop();
    }

    private void Move()
    {
        if (box.transform.position.x<stopPos)
        {
            box.transform.position = new Vector2(transform.position.x + 0.3f, transform.position.y);
        } else if(box.transform.position.x>stopPos){
            box.transform.position = new Vector2(transform.position.x - 0.3f, transform.position.y);
        }
    }

    private void Stop()
    {
        if (box.transform.position.x<= stopPos +0.3f && box.transform.position.x>=stopPos -0.3f)
        {
            box.transform.position = new Vector2(stopPos, box.transform.position.y);
        }
    }
}
