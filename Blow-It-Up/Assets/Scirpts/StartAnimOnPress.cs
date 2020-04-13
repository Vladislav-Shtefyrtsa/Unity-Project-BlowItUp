using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimOnPress : MonoBehaviour {

    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Animator>().Play("ButtonPressSettingsAnimation");
        StartCoroutine(Reset());
    }
    IEnumerator Reset()
    {
        yield return new WaitForSeconds(0.1f);
        this.gameObject.GetComponent<Animator>().Play("New State");
    }
}
