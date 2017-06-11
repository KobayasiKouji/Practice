using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletCeate : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    GameObject ExploadObj;
    [SerializeField]
    GameObject ExploadPos;
    [SerializeField]
    float speed;
    [SerializeField]
    float bulletStartPos;

    private float Angle;
    void Start()
    {
        transform.localEulerAngles
    = new Vector3(
        transform.localEulerAngles.x + 270,
        transform.localEulerAngles.y,
        transform.localEulerAngles.z
);
        bulletStar();
    }
    void Update()
    {
        transform.Translate(new Vector3(0, speed, 0));
    }

    void bulletStar()
    {
        Angle = (this.transform.eulerAngles.y + 90) / 180 * Mathf.PI;
        Vector3 bulletlocation = new Vector3(
            (bullet.transform.position.x + (bulletStartPos * Mathf.Cos(-Angle))),
            bullet.transform.position.y + 60,
            (bullet.transform.position.z + (bulletStartPos * Mathf.Sin(-Angle)))
            );
        if (this.transform.position != bulletlocation)
        {
            this.transform.position +=
                (bulletlocation - this.transform.position) * 0.08f;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
        Explode();
    }
    void Explode()
    {
        Instantiate(ExploadObj, ExploadPos.transform.position, Quaternion.identity);
        Debug.Log("爆発モーション出したよ");
    }
}
