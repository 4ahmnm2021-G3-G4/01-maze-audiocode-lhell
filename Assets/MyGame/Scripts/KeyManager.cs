using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public GameObject key;
    public Animator animator;

    private void OnTriggerEnter(Collider key)
    {

        Debug.Log("key to door works");

        Destroy(key.gameObject);

        animator.SetBool("key", true);
    }
}
