using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {
    [SerializeField]
    public GameObject ExploadObj;
    [SerializeField]
    public float DestroyTime;
    // Use this for initialization
    void Start () {
        StartCoroutine(Destroy());
	}
	
	IEnumerator Destroy()
    {
        yield return new WaitForSeconds(DestroyTime);
        Destroy(gameObject);
        Debug.Log(Time.deltaTime);
    }
}
