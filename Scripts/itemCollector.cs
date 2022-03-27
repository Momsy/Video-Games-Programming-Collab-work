using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    int pieces = 0;
    [SerializeField] Text txtpieces;

 private void OnTriggerEnter(Collider skurt){
     if (skurt.gameObject.CompareTag("Coin"))
     {
         Destroy(skurt.gameObject);
         pieces = pieces + 1 ;
         txtpieces.text = "Coins: " + pieces;
     }
 }
}
