using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour {

    public float timeOfTravel = 5f; //time after object reach a target place 
    public float currentTime = 0; // actual floting time 
    public float normalizedValue;
    public RectTransform rectTransform; //getting reference to this component 

    private void OnMouseDown()
    {
       
        StartCoroutine(LerpObject());
    }

    IEnumerator LerpObject()
    {
        while (currentTime <= timeOfTravel)
        {
            currentTime += Time.deltaTime;
            normalizedValue = currentTime / timeOfTravel; // we normalize our time 

            rectTransform.anchoredPosition = Vector3.Lerp(rectTransform.anchoredPosition,new Vector2(rectTransform.anchoredPosition.x,10f), normalizedValue);
            yield return null;
            if (currentTime >= 1f)
            {
                currentTime = 0;
                break;
            }
        }
        if(currentTime >= timeOfTravel){
            currentTime = 0;
        }
        StopCoroutine(LerpObject());
    }
}
