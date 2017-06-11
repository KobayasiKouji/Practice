using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour {
    [SerializeField]
    GameObject sentor;
    [SerializeField]
    GameObject Target;
    [SerializeField]
    GameObject Camera;
    [SerializeField]
    float RotateSpeed;

    private Vector3 offset;
    Vector3 targetPos;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        //transform.position += Target.transform.position - targetPos;
        targetPos = Target.transform.position;

        sentor.transform.position = new Vector3(Target.transform.position.x, Target.transform.position.y,Target.transform.position.z);
            //Target.transform.position;

        Vector3 newPosition = transform.position;
        newPosition.x = Target.transform.position.x + offset.x;
        newPosition.y = Target.transform.position.y + offset.y;
        newPosition.z = Target.transform.position.z + offset.z;
        //Camera.transform.position = Vector3.Lerp(transform.position, newPosition, 5.0f * Time.deltaTime);

        sentor.transform.RotateAround(sentor.transform.position, Vector3.up, (Input.GetAxisRaw("Horizontal")*RotateSpeed));
        // sentor.transform.RotateAround(sentor.transform.position, Vector3.up, (Input.GetAxisRaw("Horizontal")));


        //Camera.transform.LookAt(sentor.transform.position);
	}
}
