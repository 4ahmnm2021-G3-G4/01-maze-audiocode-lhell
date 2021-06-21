using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMainDoor : MonoBehaviour
{

    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Detect collision");

        animator.SetBool("collision", true);
    }
}
