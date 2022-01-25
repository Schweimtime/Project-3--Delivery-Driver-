using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 206;
    [SerializeField] float moveSpeed = 8;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
       float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);   
           
    }
}
 