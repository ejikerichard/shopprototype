using UnityEngine;

// Ensure the component is present on the gameobject the script is attached to
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    // Local rigidbody variable to hold a reference to the attached Rigidbody2D component
    new Rigidbody2D rigidbody2D;
    new Animator animator;

    public float movementSpeed = 1000.0f;

    void Awake()
    {
        // Setup Rigidbody for frictionless top down movement and dynamic collision
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        rigidbody2D.isKinematic = false;
        rigidbody2D.angularDrag = 0.0f;
        rigidbody2D.gravityScale = 0.0f;
    }

    void FixedUpdate(){
        // Handle user input
        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        Move(targetVelocity);
    }

    void Move(Vector2 targetVelocity)
    {        
        // Set rigidbody velocity
        rigidbody2D.velocity = (targetVelocity * movementSpeed) * Time.deltaTime; // Multiply the target by deltaTime to make movement speed consistent across different framerates
        animator.SetFloat("horizontal", rigidbody2D.velocity.x);
        animator.SetFloat("vertical", rigidbody2D.velocity.y);

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical")== 1 || Input.GetAxisRaw("Vertical") == -1){
            animator.SetFloat("zeroHorizontal", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("zeroVertical", Input.GetAxisRaw("Vertical"));
        }

        if(Input.GetAxisRaw("Horizontal") > 0){
            transform.eulerAngles = new Vector2(transform.eulerAngles.x, 0);
        }
        else if(Input.GetAxisRaw("Horizontal") < 0){

            transform.eulerAngles = new Vector2(transform.eulerAngles.x, 180);
        }
    }
}
