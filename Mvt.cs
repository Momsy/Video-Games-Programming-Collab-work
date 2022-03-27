using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mvt : MonoBehaviour
{
    [SerializeField] GameObject[] mvtpt;// general to help us to reuse that var on whatever we want 
    int currentptIndex = 0; //keep track index of the current pt

    [SerializeField] float speed = 1f; 

    void Update()// the character mvt is base on physics or our platform will move in some specific direction
    {
        if(Vector3.Distance(transform.position, mvtpt[currentptIndex].transform.position) < .1f)
        {
            currentptIndex++;// for the incrementation like the i index in a loop
            if(currentptIndex >= mvtpt.Length){
                currentptIndex = 0 ; //to start at the first pt 
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, mvtpt[currentptIndex].transform.position, speed * Time.deltaTime);// reffer to  the transport component 
    }

}
//this code will helps up for our platform if the platform touch the limit she will come back
// thatis going to give movement to the platforme