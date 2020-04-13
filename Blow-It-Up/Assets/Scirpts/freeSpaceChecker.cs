using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freeSpaceChecker : MonoBehaviour {

    public GameObject bombball, bombneedle;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name != "Zone" || other.gameObject.name.Contains("Star") == false)
        {
            if (other.gameObject.name != "CubeSmall")
            {
                bombball.GetComponent<MeshRenderer>().enabled = false;
                bombneedle.GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
}
