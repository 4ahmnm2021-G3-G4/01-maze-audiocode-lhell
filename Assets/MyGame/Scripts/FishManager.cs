﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    public GameObject fishObject;
    public Animator animator;
    public GameObject catMeow;
    public GameObject catPurr;


    public bool fish;

    void start()
    {
        fish = false;
    }
    private void OnTriggerEnter(Collider fish)
    {
        //change cat sound
        //open cat gate

        Debug.Log("fish entered trigger zone");

        animator.SetBool("fish", true);

        catMeow.SetActive(false);
        catPurr.SetActive(true);
    }
}
