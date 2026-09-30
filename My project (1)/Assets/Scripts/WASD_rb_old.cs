using UnityEngine;
using UnityEngine.InputSystem;

public class WASD_rb_old : MonoBehaviour
{
    //Variables
    public Rigidbody2D rb;
    public float forceamount = 4.24f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //script the rigidbody from my gameobject onto this script
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //make the square move up if I press W
        if(Input.GetKey(KeyCode.W))
        {
        rb.AddForce(Vector2.up * forceamount);
        }
    
        //make the square move down if I press S
        if(Input.GetKey(KeyCode.S))
        {
        rb.AddForce(Vector2.down * forceamount);
        }
        
        //make the square move left if I press A
        if(Input.GetKey(KeyCode.A))
        {
        rb.AddForce(Vector2.left * forceamount);
        }

        //make the square move right if I press D
        if(Input.GetKey(KeyCode.D))
        {
        rb.AddForce(Vector2.right * forceamount);
        }
    }
}