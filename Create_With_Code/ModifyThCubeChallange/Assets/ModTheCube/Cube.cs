using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float _rotationX; 
    public float _rotationY; 
    public float _rotationZ; 
    public Vector3 _position;




    void Start()
    {
        transform.position = _position;
        transform.localScale = Vector3.one * 1.3f;


        float matColor = Random.Range(0f, 10f);
        float matColorB = Random.Range(0f, 10f);
        
        Material material = Renderer.material;
        material.color = new Color(matColor , matColorB , 10f, 0.4f);
        
        
    }
    
    void Update()
    {
        transform.Rotate(_rotationX * Time.deltaTime, _rotationY * Time.deltaTime, _rotationZ * Time.deltaTime);
    }
}
