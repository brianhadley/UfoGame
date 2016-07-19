using UnityEngine;
using System.Collections;

public class MasterScript : MonoBehaviour {

    public GameObject CurrentLevel;
    public GameObject Player;

    public void CollectableEncountered(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);

        }

        int curLevelActive = 0;
        foreach (Transform child in CurrentLevel.transform.FindChild("Pickups"))
        {
            if (child.tag == "PickUp" && child.gameObject.activeSelf)
            {
                curLevelActive++;
            }
        }

        if (curLevelActive == 0)
        {
            foreach (BoxCollider2D collider in CurrentLevel.GetComponents<BoxCollider2D>())
            {
                collider.enabled = false;
            }

            LevelTracking lt = CurrentLevel.GetComponent<LevelTracking>();
            CurrentLevel.tag = "Completed Level";

            GameObject nextLevel = GameObject.FindGameObjectWithTag("Level");

            nextLevel.GetComponent<LevelTracking>().Enable();
            CurrentLevel = nextLevel;

        }



    }
	
}
