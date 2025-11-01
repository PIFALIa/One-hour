using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Animator animator;
    private Rigidbody rb;

    void Start()
    {
    
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");   


        Vector3 move = new Vector3(moveX, 0, moveZ).normalized;


        if (move.magnitude > 0)
        {

            rb.MovePosition(transform.position + move * moveSpeed * Time.deltaTime);

            transform.forward = move;

            animator.SetBool("run", true);
        }
        else
        {
           
            animator.SetBool("run", false);
        }

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
            
        }
    }
}