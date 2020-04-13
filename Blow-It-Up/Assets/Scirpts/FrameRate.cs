using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRate : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Application.targetFrameRate = 60;
        Time.timeScale = 0.0001f;
    }

}
