using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    public string sendMessage = "";
    public string sendMessage2 = "";
   
   void OnCollisionEnter2D(Collision2D other)
   {
       if(other.gameObject.CompareTag("Player"))
       {
           
           flowchart.SendFungusMessage(sendMessage);
           flowchart.SendFungusMessage(sendMessage2);
       }
   }
}
