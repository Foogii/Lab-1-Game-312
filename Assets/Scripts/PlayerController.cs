using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position; //Gets the current position of the gameObject, and stores it into a vector 3
        pos.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime; //Updates vector3 pos on the x axis by moveSpeed when Input"Horizontal" is active
        pos.z += moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime; //Updates vector3 pos on the y axis by moveSpeed when Input"Vertical" is active

        transform.position = pos; //Updates the gameObjects position with the new position/vector3
    }

} 
