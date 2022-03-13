using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] LayerMask groundLayers;
    private float gravity = -50f;
    private CharacterController characterController;
    private Vector3 velocity;
    private bool isGrounded;
    [SerializeField] private float F_speed = 1f; // Forward/Backward speed
    [SerializeField] private float L_speed = 100f; // Left/Right speed

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundLayers, QueryTriggerInteraction.Ignore);

        if(isGrounded && velocity.y < 0){

            velocity.y = 0;
        }
        else{

            velocity.y += gravity * Time.deltaTime;
        }
        
        characterController.Move(velocity * Time.deltaTime);

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * F_speed *Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * L_speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * F_speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * L_speed * Time.deltaTime);
    
    }
}
