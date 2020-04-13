using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarsChecker : MonoBehaviour {

    public GameObject[] stars;
    private void Start()
    {
        if(PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.name + "0"))
        {
            stars[0].SetActive(false);
            stars[1].SetActive(false);
            stars[2].SetActive(false);
        }
        if(PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.name + "1"))
        {
            stars[0].SetActive(true);
            stars[1].SetActive(false);
            stars[2].SetActive(false);
        }
        if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.name + "2"))
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(false);
        }
        if(PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.name + "3"))
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
        }
    }
}
