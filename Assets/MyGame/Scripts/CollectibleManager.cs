using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{

    public bool doorOpen;
    public PlayerData myPlayerData;

    public Animator animator;

    void Start()
    {

        doorOpen = false;

    }
    public void Update()
    {

        if (myPlayerData.countCollectibles == 3)

        {

            Debug.Log("Alles eingesammelt");
            //open the second gate

            animator.SetBool("fruitGate", true);

        }

    }
}

