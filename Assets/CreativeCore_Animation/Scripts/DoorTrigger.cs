using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("A");
        anim.SetTrigger("PlayerProximity");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("B");
        anim.SetTrigger("PlayerProximity");
    }
}
