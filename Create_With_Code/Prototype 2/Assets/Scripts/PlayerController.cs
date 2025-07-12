using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerInputH;
    public float playerInputV;
    float speed = 15.0f;
    float xRange = 22.0f;
    float zRange = 5.0f;
    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get the user Input in X/Y
        playerInputH = Input.GetAxis("Horizontal");
        playerInputV = Input.GetAxis("Vertical");


        // move the plyer in X/Z axis
        transform.Translate(Vector3.right * Time.deltaTime * speed * playerInputH);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * playerInputV);

        // veryfi the if the player position is < -10x , > 10
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, zRange);
        }
        else if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,zRange);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //lounch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
