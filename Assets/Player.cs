using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody playerRB;
    private BoxCollider playerBx;
    private Renderer colorRender;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerBx = GetComponent<BoxCollider>();
        colorRender = GameObject.Find("Indicator").GetComponent<Renderer>();
        colorRender.material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddF();
        }
    }
    public void AddF()
    {
        playerRB.AddForce(Vector3.right*500f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        playerRB.isKinematic = true;
        playerBx.isTrigger = true;
        
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("worked!!");
        colorRender.material.color = Color.green;
    }
    private void OnTriggerExit(Collider other)
    {
        colorRender.material.color = Color.blue;
    }
    
}
