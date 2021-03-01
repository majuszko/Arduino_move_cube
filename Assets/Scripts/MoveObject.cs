using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public SerialController SC;
    public Rigidbody rb;
    void Start()
    {
        SC = GameObject.Find("SerialController").GetComponent<SerialController>();
        
    }

    private void Update()
    {
        string message = SC.ReadSerialMessage();

        if (message == null)
            return;

        // Check if the message is plain data or a connect/disconnect event.
        if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_CONNECTED))
            Debug.Log("Connection established");
        else if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_DISCONNECTED))
            Debug.Log("Connection attempt failed or disconnection detected");
        else
        {
            float distance = float.Parse(message);
            Debug.Log("Message arrived: " + distance); 
            //rb.velocity = new Vector3(distance, 0, rb.velocity.z);
            //rb.AddForce(0, 0, distance*10*Time.deltaTime);
        }

        
    }

    
    void OnMessageArrived(string msg)
    {
        
        float speed = float.Parse(msg) ;
        //cubeModifier.gameObject.transform.Translate(Vector3.up * Time.deltaTime * speed);
        
        //rb.AddForce(0, 0, speed*10*Time.deltaTime);
        rb.velocity = new Vector3(0, 0, speed*5*Time.deltaTime);
        
    }
    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
    
}
