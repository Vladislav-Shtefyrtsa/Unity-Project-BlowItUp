using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : MonoBehaviour {

    public GameObject sound, vibr, dkm,sline,vline,dline,bg;

    private void Start()
    {
        if(PlayerPrefs.GetInt("DM") == 0){
            bg.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            dline.SetActive(true);
        }
        if (PlayerPrefs.GetInt("DM") == 1)
        {
            bg.GetComponent<SpriteRenderer>().color = new Color(0.13f, 0.13f, 0.13f, 1);
            dline.SetActive(false);
        }
        if(PlayerPrefs.GetInt("Sound") == 0){
            sline.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            sline.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Vibrate") == 0) {
            vline.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Vibrate") == 1) {
            vline.SetActive(false);
        }
    }

    private void OnMouseUp()
    {
        if (this.name == "Circle") {
            if(vline.activeSelf){
                vline.SetActive(false);
                PlayerPrefs.SetInt("Vibrate", 1);
            }else{
                vline.SetActive(true);
                PlayerPrefs.SetInt("Vibrate", 0);
            }
        }
        if (this.name == "Circle (1)") {
            if (sline.activeSelf)
            {
                sline.SetActive(false);
                PlayerPrefs.SetInt("Sound", 1);
            }
            else
            {
                sline.SetActive(true);
                PlayerPrefs.SetInt("Sound", 0);
            }
        }
        if (this.name == "Circle (2)") {
            if (dline.activeSelf)
            {
                dline.SetActive(false);
                PlayerPrefs.SetInt("DM", 1);
                bg.GetComponent<SpriteRenderer>().color = new Color(0.13f, 0.13f, 0.13f, 1);
            }
            else
            {
                dline.SetActive(true);
                PlayerPrefs.SetInt("DM", 0);
                bg.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            }
        }
    }
}
