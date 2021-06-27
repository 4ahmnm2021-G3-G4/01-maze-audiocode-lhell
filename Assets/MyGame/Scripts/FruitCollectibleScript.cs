using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollectibleScript : MonoBehaviour
{
    [SerializeField] PlayerData myPlayerData;
    void Start()
    {
        Debug.Log("started fruit script");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger detected" + other.gameObject.name);

        myPlayerData.countCollectibles++;

        Destroy(gameObject);
    }

}

