using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour

{
   //public bool OnGround;
   public Animator animator;
   public LayerMask groundLayers;

   public float speed = 5;
   //public float landing = 2.5f;

   public float jumpForce = 4;

   private Rigidbody2D rb;

   

    #region Monobehaviour API
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        animator = GetComponent<Animator>();

    }
    private void OnCollisionEnter2D(Collision2D collision)

    {

        if(collision.gameObject.tag == "Ground")

    {

        animator.SetBool("On ground", true);

    }

}
    // Update is called once per frame
    void Update()
    {
       Jump();
       animator.SetBool("falling", rb.velocity.y<-0.1);


        PlayerWeapn();
      
        
    }
    
private void PlayerWeapn(){
     if (Input.GetKey(KeyCode.A)){
            animator.Play("PlayerWeapon");
            animator.SetBool("On ground", false);
       }
}

    private void Jump(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

       
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("Jump");
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            
            animator.SetBool("On ground", false);
            
        }       
    }
   

    #endregion
}
