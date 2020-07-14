using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public Transform ballPos;
    public GameObject ball;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject b =Instantiate(ball, ballPos.position, Quaternion.identity) as GameObject;
            b.GetComponent<Rigidbody>().AddForce(ballPos.transform.forward *  2000f);
        }
    }
}
