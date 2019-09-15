using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform launchPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //Check if left mouse is being held down
        {
            if(!IsInvoking("fireBullet")) //If it is not being invoked
            {
                InvokeRepeating("fireBullet", 0f, 0.1f); //InvokeRepeating will repeatedly call the method fireBullet() until it is cancelled
            }
        }

        if(Input.GetMouseButtonUp(0)) //Checks if left mouse is not being held down
        {
            CancelInvoke("fireBullet"); //Cancels the invoke so the method is no longer being called
        }
    }

    void fireBullet()
    {
        // Create a GameObject called bullet and assign the bulletPrefab to it
        GameObject bullet = Instantiate(bulletPrefab) as GameObject; 
        //Set the bullets position to specified location (launchPosition)
        bullet.transform.position = launchPosition.position;
        //Retrieve the rigidbody component from the buller and push the object forwards
        bullet.GetComponent<Rigidbody>().velocity = transform.parent.forward * 100;
    }
}
