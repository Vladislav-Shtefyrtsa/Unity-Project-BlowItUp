using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScaler : MonoBehaviour {

    public GameObject backgorund;
    public GameObject PlayButton,typeLevels;
    public GameObject rightCorner, leftCorner, rightCenter, leftCenter;
    public RectTransform dropdown;
    public GameObject heightPosition,topPosition,scroll;

	void Update () {
        Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,0));
        backgorund.transform.localScale = new Vector3(207.882f*pos.x,1000,1);
        PlayButton.transform.localScale = new Vector3(pos.x/5.466102f, pos.x/5.466102f, pos.x/5.466102f);
        leftCorner.transform.position = new Vector3(-pos.x + 0.5f,leftCorner.transform.position.y,leftCorner.transform.position.z);
        rightCorner.transform.position = new Vector3(pos.x - 0.5f, rightCorner.transform.position.y, rightCorner.transform.position.z);
        rightCenter.transform.position = new Vector3(rightCorner.transform.position.x/3, rightCenter.transform.position.y, rightCenter.transform.position.z);
        leftCenter.transform.position = new Vector3(leftCorner.transform.position.x / 3, leftCenter.transform.position.y, leftCenter.transform.position.z);
        typeLevels.transform.localScale = new Vector3(pos.x/2.854212f,pos.x/2.854212f,pos.x/2.854212f);
        dropdown.sizeDelta = new Vector2(dropdown.sizeDelta.x, topPosition.transform.position.y - heightPosition.transform.position.y);
        
        scroll.transform.position = new Vector3(scroll.transform.position.x, dropdown.transform.position.y, scroll.transform.position.z);
    }

    //private void Update()
    //{
        //scroll.transform.position = new Vector3(scroll.transform.position.x,dropdown.transform.position.y,scroll.transform.position.z);
   //}
}
