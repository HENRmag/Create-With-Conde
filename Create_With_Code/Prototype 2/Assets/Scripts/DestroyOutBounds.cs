using UnityEngine;

public class DestroyOutBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float downBound = -10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
         // quando um animal passar o limite de visão do player ele será removido
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < downBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
