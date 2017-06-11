using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField]
    public GameObject target;
    [SerializeField]
    public float CameraLength = 100f;

    private float Angle;

    void Start()
    {
    }


    void Update()
    {
        Angle = (this.transform.eulerAngles.y + 90) / 180 * Mathf.PI;
        Vector3 CameraLocation = new Vector3(
            (target.transform.position.x + (CameraLength * Mathf.Cos(-Angle))),
            target.transform.position.y + 5,
            (target.transform.position.z + (CameraLength * Mathf.Sin(-Angle)))
            );
        if (this.transform.position != CameraLocation)
        {
            this.transform.position +=
                (CameraLocation - this.transform.position) * .1f;
        }
    }
}

