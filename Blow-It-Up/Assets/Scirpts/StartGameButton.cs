using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class StartGameButton : MonoBehaviour
{
    Vector2 touchStartPos, touchEndPos;
    string varrr,thisObjectName;
    string levelNum;
    int i=0;


    private void OnMouseDown()
    {
        touchStartPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
      
    }
    private void OnMouseUp()
    {
       
        touchEndPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        if(Mathf.Abs(touchEndPos.y - touchStartPos.y) < 2.5f)
        {
            varrr = transform.parent.name;
            thisObjectName = this.name.Remove(0, 6);
            varrr = varrr + thisObjectName;
            PlayerPrefs.SetString("GameLevel",varrr);
            GameObject fade = GameObject.Find("Fade");
            fade.GetComponent<Animator>().Play("EndFadeAnimation");
            levelNum = this.gameObject.name.Remove(0, 7);
            levelNum = levelNum.Remove(levelNum.Length - 1);
            int levelIntNum = Convert.ToInt32(levelNum);
            PlayerPrefs.SetInt("CurrentLevel", levelIntNum);
            StartCoroutine(fadein());
        }
    }
    IEnumerator fadein()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("SampleScene");
    }
}
