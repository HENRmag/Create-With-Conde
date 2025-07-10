using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControll : MonoBehaviour
{   
    // private varibles 
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // we get player input action
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle forward based Vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        
        // We rotate the vehicle based Horizontal Input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
        
    
        
    }
}
