using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    [SerializeField]
    public GameObject obj;
    [SerializeField]
    GameObject bullet;
    public float movespeed;
    public float rotateSpeed;
    // Use this for initialization
    public GameObject camera;
	void Start () {
        camera = GameObject.Find("Camera");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.S)) {
            obj.transform.Translate(0, 0, -(Input.GetAxisRaw("Vertical")*movespeed));
                }
        if (Input.GetKey(KeyCode.W))
        {
            obj.transform.Translate(0, 0, -(Input.GetAxisRaw("Vertical")*movespeed));
        }
        if (Input.GetKey(KeyCode.D))
        {
            obj.transform.Rotate(new Vector3(0, (Input.GetAxisRaw("Horizontal")*rotateSpeed), 0));
            //camera.transform.Rotate(new Vector3(0, rotateSpeed, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            obj.transform.Rotate(new Vector3(0, (Input.GetAxisRaw("Horizontal")*rotateSpeed), 0));
        }
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(bulletInterval());
        }
    }
    void bulletCreate()
    {
        GameObject bullet_f = Instantiate(bullet, transform.position, transform.rotation);
    }
    IEnumerator bulletInterval()
    {
        bulletCreate();
        yield return new WaitForSeconds(10f);
    }
}
