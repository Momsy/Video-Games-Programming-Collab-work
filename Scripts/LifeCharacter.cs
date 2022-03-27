using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//help me to reload the lvl 


public class LifeCharacter : MonoBehaviour
{

    public static bool die;

    private void Awake(){
        die=false;
    } 

    private void Update(){
        if (transform.position.y < -1f && !die)// helps us to check the position of the character if he fall
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<CharacterMvt>().enabled = false;
            Death();
        }
    }

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("BodyEnemy"))
        {
            Death();   
        }
    }

    public void Death()
    {
        //Invoke(nameof(ReloadingLvl), 1.3f);
        PlayerManager.isGameOver = true;
        die= true;
         
    }

    public void ReloadingLvl()//help me to reload the lvl eveytime that the player die 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//restart the same lvl but at the beginning 
    }

}
