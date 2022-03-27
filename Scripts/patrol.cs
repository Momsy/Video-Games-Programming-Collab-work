using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour
{
    public Transform[] wpt;
    public int speed;

    private int wptIndex;
    private float dist;
    void Start()
    {
        wptIndex = 0;
        transform.LookAt(wpt[wptIndex].position);

    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, wpt[wptIndex].position);
        if (dist < 1f)
        {
            IncreaseIndex();
        }
        Patrol();
    }
    void Patrol(){
        transform.Translate(Vector3.forward  * speed *Time.deltaTime);
    }

    void IncreaseIndex(){
        wptIndex = wptIndex +1 ;
        if (wptIndex >= wpt.Length)
        {
            wptIndex = 0;
        }
        transform.LookAt(wpt[wptIndex].position);
    }
}
