using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionStarter : MonoBehaviour {
    public GameObject cube,bombNeedle,bombBall;
    public float power, radius, upForce;
    private void OnMouseDown()
    {
        Detonate();
        cube.SetActive(true);
        bombNeedle.GetComponent<MeshCollider>().enabled = false;
        bombNeedle.GetComponent<MeshRenderer>().enabled = false;
        bombBall.GetComponent<MeshCollider>().enabled = false;
        bombBall.GetComponent<MeshRenderer>().enabled = false;
    }
    void Detonate(){
        Vector3 explosionPosition = this.transform.position;
        GameObject[] colliders = GameObject.FindGameObjectsWithTag("WithRB");

        foreach (GameObject hit in colliders){
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if(rb != null){
                rb.AddExplosionForce(power, explosionPosition, radius, upForce, ForceMode.Impulse);
            }
        }
    }
}
