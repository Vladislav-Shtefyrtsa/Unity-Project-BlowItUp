using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Occupied : MonoBehaviour {

    private void OnCollisionStay(Collision collision)
    {
        if ((collision.gameObject.tag == "WithRB" || collision.gameObject.tag == "FallBall" || collision.gameObject.tag == "Bomb") && this.gameObject.name.Contains("occupied") == false)
        {
            this.gameObject.name = this.gameObject.name + "occupied";
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if ((collision.gameObject.tag == "WithRB" || collision.gameObject.tag == "FallBall" || collision.gameObject.tag == "Bomb") && this.gameObject.name.Contains("occupied"))
        {
            this.gameObject.name.Replace("occupied","");
        }
    }
}
