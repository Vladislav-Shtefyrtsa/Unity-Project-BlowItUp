using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOrLevelEnable : MonoBehaviour {

    public GameObject lockLevel, CompletedLevel;

    private void OnEnable()
    {
        if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.name))
        {
            lockLevel.SetActive(false);
            CompletedLevel.SetActive(true);
        }
        else{
            lockLevel.SetActive(true);
            CompletedLevel.SetActive(false);
        }
    }
}
