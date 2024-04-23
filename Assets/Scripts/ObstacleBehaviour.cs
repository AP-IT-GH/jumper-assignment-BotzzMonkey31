using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Mauro Sterckx s142038
//Bataire Enrique s145401
public class ObstacleBehaviour : MonoBehaviour
{
    CubeAgent agent;
    // Start is called before the first frame update
    void Awake()
    {
        agent = GameObject.Find("Agent").GetComponent<CubeAgent>();
    }

    public float speed;
    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.localPosition -= new Vector3(0, 0, speed);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag=="Agent")
        {
            print("aaaa");
            agent.Hit();
        }
        if (collision.tag == "Wall")
        {
             Destroy(this.gameObject);
        }
    }
}