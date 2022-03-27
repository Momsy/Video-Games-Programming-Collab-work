using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Leavegame : MonoBehaviour
{
    public void Leaving(){
         SceneManager.LoadScene("Start");
    }
    
}
