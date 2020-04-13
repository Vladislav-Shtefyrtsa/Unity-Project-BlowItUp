using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCount : MonoBehaviour {
    bool count = true;
    public GameObject crown0, crown1, crown2, crown3,star1,star2,star3;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Contains("Star")){
            
            StartCoroutine(SS(other.gameObject));
           
            if (crown0.activeSelf)
            {
                if (count == true)
                {
                    star1.SetActive(true);
                    crown0.SetActive(false);
                    crown1.SetActive(true);
                    count = false;
                }
            }
            if (crown1.activeSelf)
            {
                if (count == true)
                {
                    star2.SetActive(true);
                    crown1.SetActive(false);
                    crown2.SetActive(true);
                    count = false;
                }
            }
            if (crown2.activeSelf)
            {
                if (count == true)
                {
                    star3.SetActive(true);
                    crown2.SetActive(false);
                    crown3.SetActive(true);
                    count = false;
                }
            }
            count = true;
        }
    }


    IEnumerator SS(GameObject other){
        other.GetComponent<MeshCollider>().enabled = false;
        other.gameObject.GetComponent<Animator>().Play("StarDestroyingAnimartion");
        yield return new WaitForSeconds(0.2f);
        Destroy(other.gameObject);
    }
}
