using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }
    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime * speed);
    }
    //public void jump()
    //{
    //    transform.localPosition = Vector3.Lerp(transform.localPosition, target.transform.position, Time.deltaTime * speed);
    //}
}
