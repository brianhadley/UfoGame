using UnityEngine;
using System.Collections;

public class LevelTracking : MonoBehaviour {

   public void Enable()
   {
        foreach (Collider2D collider in gameObject.GetComponents<Collider2D>())
        {
            collider.enabled=collider.isTrigger?true:false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
             foreach (Collider2D collider in gameObject.GetComponents<Collider2D>())
             {
                collider.enabled = collider.isTrigger ? false : true;
            }
        }           
       
        
    }
}
