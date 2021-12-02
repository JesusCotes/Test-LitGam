using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveProjectile : MonoBehaviour
{
    public float degrees;
    public float radians;
    float speed = 720;
    public GameObject target;


    [Range(0.025f, 0.5f)]
    public float height = 0.025f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        degrees += speed * Time.deltaTime;
        radians = degrees * Mathf.Deg2Rad;

        Vector3 posInCircle = Vector3.zero;
        posInCircle.y = Mathf.Sin(radians) * height;
        
        this.transform.position = target.transform.position + posInCircle;
    }
}
