using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScene : MonoBehaviour {

    public GameObject[] levels;
    int u = 0;
    string thisLevel;

    private void Start()
    {
        for(int i = 0;i < levels.Length; i++)
        {
            levels[i].SetActive(false);
        }
        levels[PlayerPrefs.GetInt("CurrentLevel")].SetActive(true);
    }

    private void OnMouseDown()
    { 
        for (int i = 0; i < levels.Length; i++)
        {
            if (levels[i].activeSelf)
            {
                u = i + 1;
                PlayerPrefs.SetInt("CurrentLevel",u);
            }
        }
        GameObject fade = GameObject.Find("Fade");
        fade.GetComponent<Animator>().Play("EndFadeAnimation");
        StartCoroutine(DelayForFade());
    }
    IEnumerator DelayForFade()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("SampleScene");
    }
}
