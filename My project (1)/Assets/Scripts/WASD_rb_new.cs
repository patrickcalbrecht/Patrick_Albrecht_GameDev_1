using UnityEngine;
using UnityEngine.InputSystem;

public class WASD_rb_new : MonoBehaviour
{
    //variables
    public Rigidbody2D rb;
    
    public float movespeed;
    
    private Vector2 movedirection;

    public InputActionReference move;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //add the direction of our movement from the reference of the new input manager we made
        movedirection = move.action.ReadValue<Vector2>();
        Debug.Log(movedirection);

        //rb.linearVelocity = new Vector2(x:movedirection.x * movespeed, y:movedirection.y * movespeed);
    }

//fixed update is called once every physics frame
private void FixedUpdate()
{
    rb.linearVelocity = new Vector2(x:movedirection.x * movespeed, y:movedirection.y * movespeed);


}




}