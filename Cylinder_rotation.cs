using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder_rotation : MonoBehaviour
{
    [SerializeField] public float TurnSpeed = 80f;
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
