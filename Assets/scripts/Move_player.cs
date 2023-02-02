
using UnityEngine;

public class Move_player : MonoBehaviour
{


    public float moveSpeed;
    public float jumpForce;
    public bool isJumping = false;
    public bool isGrounded;
    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    private Vector3 velocity = Vector3.zero;

    public Transform GroundCheckLeft;
    public Transform GroundCheckRight;
    
    void Start()
    {
        



    }


    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapArea(GroundCheckLeft.position, GroundCheckRight.position);
        float horisontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        
        if  (Input.GetButton("Jump") && isGrounded){
            isJumping =true;
            Debug.Log("button pressed");
        }


        MovePlayer(horisontalMovement);

        Flip(rb.velocity.x);

        float characterVelocity =Mathf.Abs(rb.velocity.x);
        animator.SetFloat("Speed", characterVelocity);
    }




    void MovePlayer (float _horisontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horisontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
        
        if (isJumping == true && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            Debug.Log("jumped !");
            isJumping = false;
        } 
    }

    void Flip (float _velocity){
        if(_velocity > -0.1f){
            spriteRenderer.flipX=false;

        }else if(_velocity < 0.1f){
            spriteRenderer.flipX=true;
        }

    }
}
