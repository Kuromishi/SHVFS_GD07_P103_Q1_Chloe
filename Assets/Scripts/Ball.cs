using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ball;
    public Transform t;
    public float TickRate;
    public float tickTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tickTimer += Time.deltaTime;
        if (tickTimer < TickRate) return;
        else
       // GameObject ball = Instantiate(ball,  transform);
        tickTimer = 0;

    }
}
