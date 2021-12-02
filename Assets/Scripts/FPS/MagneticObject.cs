using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticObject : MonoBehaviour
{
    public float degrees;
    public float radians;

    [Range(90, 360)]
    public float speedRotation = 90;

    public float countRotation;

    [Range(0.5f,10f)]
    public float radius = 1;

    GameObject target;

    Rigidbody objectRB;
    Collider objectCol;

    void Start(){

        objectRB = gameObject.GetComponent<Rigidbody>();
        objectCol = gameObject.GetComponent<Collider>();

    }

        void OnTriggerEnter (Collider other){

        if(other.tag == "Magnetic") {
            target = other.gameObject;
            objectCol.isTrigger = false;

        }
    }

    // Update is called once per frame
    void Update()
    {

        if(target != null){

        objectRB.useGravity = false;
        degrees += speedRotation * Time.deltaTime;
        radians = degrees * Mathf.Deg2Rad;

        Vector3 posInCircle = Vector3.zero;
        posInCircle.x = Mathf.Cos(radians) * radius;
        posInCircle.y = Mathf.Sin(radians) * radius;
        
        this.transform.position = Vector3.Lerp (this.transform.position,target.transform.position + posInCircle, 5 * Time.deltaTime);

        countRotation = degrees / 360;
        }

        else {

            objectRB.useGravity = true;
            target = null;
        }

    }
}
