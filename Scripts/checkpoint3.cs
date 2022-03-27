using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkpoint3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider skurt){
        if (skurt.gameObject.name == "Character")
        {
            SceneManager.LoadScene("END");
        }
    }
}
