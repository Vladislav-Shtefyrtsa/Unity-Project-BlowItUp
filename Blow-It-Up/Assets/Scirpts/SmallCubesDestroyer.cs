using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCubesDestroyer : MonoBehaviour {

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "CubeSmall")
        {
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
