using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectibleManagerScript : MonoBehaviour
{

    public bool collectibleGrapes;
    public bool collectibleApple;
    public bool collectibleCherries;
       

    void Update()
    {

        if (collectibleGrapes == true && collectibleApple == true && collectibleCherries == true) 
        
        {
        
        Debug.Log ("Alles eingesammelt");
        //open the second gate
        
        }
        
    }
}
