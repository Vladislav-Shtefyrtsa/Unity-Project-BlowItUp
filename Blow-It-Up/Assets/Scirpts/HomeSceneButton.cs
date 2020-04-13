using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeSceneButton : MonoBehaviour {

    private void OnMouseDown()
    {
        GameObject fade = GameObject.Find("Fade");
        fade.GetComponent<Animator>().Play("EndFadeAnimation");
        StartCoroutine(fadein());
    }
    IEnumerator fadein()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("HomeScene");
    }
}
