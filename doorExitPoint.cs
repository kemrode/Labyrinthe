using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorExitPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
        Debug.Log(other.name + " est à l'intérieur du trigger");

        }
    }

}
