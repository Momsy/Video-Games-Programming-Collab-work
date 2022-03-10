using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Diagnostics;
using System.Collections;


[System.Serializable]
public class Boudary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float F_speed = 1f; // Forward/Backward speed
    [SerializeField] private float L_speed = 1f; // Left/Right speed
    [SerializeField] Camera m_MainCamera;
    private Stopwatch timer;
    private float t = 400f;



 

    private void Awake()
    {

        timer = new Stopwatch();

        timer.Start();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * V_speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * L_speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * F_speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * L_speed * Time.deltaTime);
    }
