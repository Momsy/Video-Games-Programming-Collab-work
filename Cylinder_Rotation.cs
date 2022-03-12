using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder_Rotation : MonoBehaviour
{
    [SerializeField] public float TurnSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
    }
}
