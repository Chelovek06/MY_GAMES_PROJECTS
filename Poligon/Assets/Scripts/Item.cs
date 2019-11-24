using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    private int _score;

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Item: " + itemName);
        Destroy(this.gameObject);
        if(itemName == "FirstAidKit"){
            PlayerCharacter player = other.GetComponent<PlayerCharacter>();
            if(player != null)
            {
                player.ChangeHealth(75);
            }
        }
        
        if(itemName == "AidKit")
        {
            PlayerCharacter player = other.GetComponent<PlayerCharacter>();
            if(player != null)
            {
                player.ChangeHealth(100);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
