using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMvt : MonoBehaviour
{

    Rigidbody sd;// that will helps us to gain some precious time to avoid to re write everytime rigidbody
   
    [SerializeField] Transform feetdetection;// to link it to our player 
    [SerializeField] LayerMask feet;
    [SerializeField] public float F_speed = 5f;

    public static bool end;

        // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" Test for see if there is some error");// debug test 
        sd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && isGrounded()){ //adding physics to move our character in the direction that we want 
            Space();// that will helps us to now in which direction oour character jump
        }

        if(Input.GetKey("up"))//move up
        {
            //sd.velocity = new Vector3(0,0,5);
            transform.Translate(Vector3.forward * F_speed *Time.deltaTime);
        }
           if(Input.GetKey("right"))//move right
        {
            //sd.velocity = new Vector3(5,0,0);
             transform.Translate(Vector3.right * F_speed * Time.deltaTime);
        }
             if(Input.GetKey("left"))//move left
        {
            //sd.velocity = new Vector3(-5,0,0);
            transform.Translate(Vector3.left * F_speed * Time.deltaTime);
        }
             if(Input.GetKey("down"))//move down
        {
            //sd.velocity = new Vector3(0,0,-5);
            transform.Translate(Vector3.back * F_speed * Time.deltaTime);
        }
    }

    void Space(){
        sd.velocity = new Vector3(0, 5, 0);
    }

    
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("EnemyHead"))
        {
            Destroy(collision.transform.parent.gameObject);// we want to destroy the parent aswelll
            Space();
        }
    }
    
    bool isGrounded()// that method help me to detect if the character is touching the ground or not by returning true or false 
    {
            return Physics.CheckSphere(feetdetection.position, 0.1f, feet);// we want to make that happen everytime that the player press space
    }
}

