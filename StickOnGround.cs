using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickOnGround : MonoBehaviour// this class will help us to detect when a player is touching the moving platform
{
   private void OnCollisionEnter(Collision collision)
   {
       if (collision.gameObject.name =="Character"){
             collision.gameObject.transform.SetParent(transform);
       }
   }

      private void OnCollisionExit(Collision collision)
   {
       if (collision.gameObject.name =="Character"){
             collision.gameObject.transform.SetParent(null);
       }
   }
}
//this method above will help the player, if the player come on a moving platform he
// doesnt need to keep moving to stay on it 