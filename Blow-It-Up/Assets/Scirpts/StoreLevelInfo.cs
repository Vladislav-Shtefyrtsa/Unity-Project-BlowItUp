using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreLevelInfo : MonoBehaviour {

    public GameObject starOne, starTwo, starThree;
    int i = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            StartCoroutine(starCounter());
            if (this.gameObject.transform.parent.name.Contains("Level"))
            {
                if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.name) == false)
                {
                    PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted") + (this.gameObject.transform.parent.name.Remove(this.gameObject.transform.parent.name.Length - 3)));
                }
                else
                {
                    if(PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.name + "0"))
                    {
                        PlayerPrefs.SetString("LevelsCompleted",PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.name + (this.gameObject.transform.parent.name + "0"),""));
                    }
                    if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.name + "1"))
                    {
                        PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.name + (this.gameObject.transform.parent.name + "1"), ""));
                    }
                    if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.name + "2"))
                    {
                        PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.name + (this.gameObject.transform.parent.name + "2"), ""));
                    }
                    if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.name + "3"))
                    {
                        PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.name + (this.gameObject.transform.parent.name + "3"), ""));
                    }
                }
            }
            else
            {
                if (this.gameObject.transform.parent.parent.name.Contains("Level"))
                {
                    if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.name) == false)
                    {
                        PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted") + this.gameObject.transform.parent.parent.name.Remove(this.gameObject.transform.parent.parent.name.Length - 3));
                    }
                    else
                    {
                        if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.name + "0"))
                        {
                            PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.name + (this.gameObject.transform.parent.parent.name + "0"), ""));
                        }                                                                                                                                                                             
                        if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.name + "1"))                                                                    
                        {                                                                                                                                                                             
                            PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.name + (this.gameObject.transform.parent.parent.name + "1"), ""));
                        }                                                                                                                                                                             
                        if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.name + "2"))                                                                    
                        {                                                                                                                                                                             
                            PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.name + (this.gameObject.transform.parent.parent.name + "2"), ""));
                        }                                                                                                                                                                             
                        if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.name + "3"))                                                                    
                        {                                                                                                                                                                             
                            PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.name + (this.gameObject.transform.parent.parent.name + "3"), ""));
                        }                                                                                                                                                                             
                    }
                }
                else
                {
                    if (this.gameObject.transform.parent.parent.parent.name.Contains("Level"))
                    {
                        if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.name) == false)
                        {
                            PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted") + this.gameObject.transform.parent.parent.parent.name.Remove(this.gameObject.transform.parent.parent.parent.name.Length - 3));
                        }
                        else
                        {
                            if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.name + "0"))
                            {
                                PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.parent.name + (this.gameObject.transform.parent.parent.parent.name + "0"), ""));
                            }
                            if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.name + "1"))
                            {
                                PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.parent.name + (this.gameObject.transform.parent.parent.parent.name + "1"), ""));
                            }
                            if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.name + "2"))
                            {
                                PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.parent.name + (this.gameObject.transform.parent.parent.parent.name + "2"), ""));
                            }
                            if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.name + "3"))
                            {
                                PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.parent.name + (this.gameObject.transform.parent.parent.parent.name + "3"), ""));
                            }
                        }
                    }
                    else
                    {
                        if (this.gameObject.transform.parent.parent.parent.parent.name.Contains("Level"))
                        {
                            if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.parent.name) == false)
                            {
                                PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted") + this.gameObject.transform.parent.parent.parent.parent.name.Remove(this.gameObject.transform.parent.parent.parent.parent.name.Length - 3));
                            }
                            else
                            {
                                if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.parent.name + "0"))
                                {
                                    PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.parent.parent.name + (this.gameObject.transform.parent.parent.parent.parent.name + "0"), ""));
                                }
                                if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.parent.name + "1"))
                                {
                                    PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.parent.parent.name + (this.gameObject.transform.parent.parent.parent.parent.name + "1"), ""));
                                }
                                if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.parent.name + "2"))
                                {
                                    PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.parent.parent.name + (this.gameObject.transform.parent.parent.parent.parent.name + "2"), ""));
                                }
                                if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.parent.name + "3"))
                                {
                                    PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.parent.parent.name + (this.gameObject.transform.parent.parent.parent.parent.name + "3"), ""));
                                }
                            }
                        }
                        else
                        {
                            if (this.gameObject.transform.parent.parent.parent.parent.parent.name.Contains("Level"))
                            {
                                if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.parent.parent.name) == false)
                                {
                                    PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted") + this.gameObject.transform.parent.parent.parent.parent.parent.name.Remove(this.gameObject.transform.parent.parent.parent.parent.parent.name.Length - 3));
                                }
                                else
                                {
                                    if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.parent.parent.name + "0"))
                                    {
                                        PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.parent.parent.parent.name + (this.gameObject.transform.parent.parent.parent.parent.parent.name + "0"), ""));
                                    }
                                    if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.parent.parent.name + "1"))
                                    {
                                        PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.parent.parent.parent.name + (this.gameObject.transform.parent.parent.parent.parent.parent.name + "1"), ""));
                                    }
                                    if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.parent.parent.name + "2"))
                                    {
                                        PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.parent.parent.parent.name + (this.gameObject.transform.parent.parent.parent.parent.parent.name + "2"), ""));
                                    }
                                    if (PlayerPrefs.GetString("LevelsCompleted").Contains(this.gameObject.transform.parent.parent.parent.parent.parent.name + "3"))
                                    {
                                        PlayerPrefs.SetString("LevelsCompleted", PlayerPrefs.GetString("LevelsCompleted").Replace(this.gameObject.transform.parent.parent.parent.parent.parent.name + (this.gameObject.transform.parent.parent.parent.parent.parent.name + "3"), ""));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        
    }
    IEnumerator starCounter()
    {
        yield return new WaitForSeconds(1f);
        if (starOne.activeSelf)
        {
            i = 1;
        }
        if (starTwo.activeSelf)
        {
            i = 2;
        }
        if (starThree.activeSelf)
        {
            i = 3;
        }
        PlayerPrefs.SetString("LevelsCompleted",PlayerPrefs.GetString("LevelsCompleted") + i.ToString());
        Debug.Log(PlayerPrefs.GetString("LevelsCompleted"));
    }
}
