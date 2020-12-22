using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorExitPoint : MonoBehaviour
{
    public bool CanOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player" && CanOpen==true)
        {
            GetComponent<Animator>().enabled = true;
        }
    }

}
