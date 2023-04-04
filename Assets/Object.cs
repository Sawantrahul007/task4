using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    private Rigidbody objectRb;
    // Start is called before the first frame update
    void Start()
    {
        objectRb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("gg");
        objectRb.AddForce(-Vector3.right * 10f);
    }
}
