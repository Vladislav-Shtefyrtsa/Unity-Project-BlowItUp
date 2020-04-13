using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDrag : MonoBehaviour {

    public GameObject bomb,bombball,bombneedle;
    public GameObject prefab;
    public Material material,bombballmatl,bombneedlemat;

    private void Start()
    {
        Time.timeScale = 1f;
    }
    private void OnMouseEnter()
    {
        StartCoroutine(Delay());
    }
    private void OnMouseDown()
    {
        StartCoroutine(Delay());
    }
    private void OnMouseExit()
    {
        bomb.SetActive(false);
        bombball.GetComponent<MeshRenderer>().material = material;
        bombneedle.GetComponent<MeshRenderer>().material = material;
        bombball.GetComponent<MeshRenderer>().enabled = false;
        bombneedle.GetComponent<MeshRenderer>().enabled = false;
    }

    private void Update()
    {
        if(Input.touchCount == 0)
        {
            bomb.SetActive(false);
            bombball.GetComponent<MeshRenderer>().material = material;
            bombneedle.GetComponent<MeshRenderer>().material = material;
            bombball.GetComponent<MeshRenderer>().enabled = false;
            bombneedle.GetComponent<MeshRenderer>().enabled = false;
        }
    }
    IEnumerator Delay()
    {
        yield return null;
        bombball.GetComponent<MeshRenderer>().material = material;
        bombneedle.GetComponent<MeshRenderer>().material = material;
        bombball.GetComponent<MeshRenderer>().enabled = false;
        bombneedle.GetComponent<MeshRenderer>().enabled = false;
        bomb.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.7912904f, this.transform.position.z);
        bomb.SetActive(true);
        bombball.GetComponent<MeshRenderer>().enabled = true;
        bombneedle.GetComponent<MeshRenderer>().enabled = true;
        yield return new WaitForSeconds(0.05f);
        bombball.GetComponent<MeshRenderer>().material = bombballmatl;
        bombneedle.GetComponent<MeshRenderer>().material = bombneedlemat;
    }

    private void OnMouseUp()
    {
        if (bombneedle.GetComponent<MeshRenderer>().enabled == true && bombball.GetComponent<MeshRenderer>().enabled == true)
        {
            Instantiate(prefab, bomb.transform.position, Quaternion.identity);
            bomb.SetActive(false);
        }

    }
}
