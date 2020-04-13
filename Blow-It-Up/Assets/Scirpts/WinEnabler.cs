using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinEnabler : MonoBehaviour {

    public GameObject win;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "FallBall"){
            win.SetActive(true);
            GameObject gg = GameObject.Find("Boxes");
            gg.GetComponent<Animator>().enabled = false;
        }
    }
}
