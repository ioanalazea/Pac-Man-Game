using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
  void Update(){
    
  }
   public void QuitGame () {
 Application.Quit ();
 Debug.Log("Game is exiting");
 //Just to make sure its working
 }
}
