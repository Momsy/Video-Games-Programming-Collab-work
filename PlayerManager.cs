using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;    //declaration of the variable to know if the game is over or not.
     //declaration of the variable to know if the game is finished or not.
    public GameObject gameOverScreen; //declaration of the gameoverscreen, displayed when the rocket hit an obstacle or when a bullet hit the rocket
    //public GameObject gameEndScreen;   //declaration of the gameendscreen, displayed when the player finished the level1 and the level2.

    private void Awake()
    {
        isGameOver = false;         //instanciate the gameover value as false when the game start.
                //instanciate the endgame value as false when the game start.
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            gameOverScreen.SetActive(true);
            GetComponent<CharacterMvt>().F_speed = 0f;   //if the game is over (let's see in the Playercontroller script), the gameoverscreen is active with the restart button.
        }

    }

    public void ReloadingLvl()//help me to reload the lvl eveytime that the player die 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//restart the same lvl but at the beginning 
    }

    public void ReloadingLvl2()//help me to reload the lvl eveytime that the player die 
    {
        SceneManager.LoadScene("Lvl2");//restart the same lvl but at the beginning 
    }

    public void ReloadingLvl3()//help me to reload the lvl eveytime that the player die 
    {
        SceneManager.LoadScene("Lvl3");//restart the same lvl but at the beginning 
    }

   }