using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleCollider : MonoBehaviour
{
    public void OnTriggerEnter(Collider other) 
    {
        Component.GetComponent(collectibleGrapes) = true;
    }
}
