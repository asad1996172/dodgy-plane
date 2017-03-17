using UnityEngine;

namespace UnitySampleAssets._2D
{

    public class PlatformerCharacter2D : MonoBehaviour
    {
        private bool facingRight = true; // For determining which way the player is currently facing.

        public float maxSpeed = 10f; // The fastest the player can travel in the x axis.
       // [SerializeField] private float jumpForce = 400f; // Amount of force added when the player jumps.	

       // [Range(0, 1)] [SerializeField] private float crouchSpeed = .36f;
                                                     // Amount of maxSpeed applied to crouching movement. 1 = 100%

       


        void FixedUpdate()
        {
			float move = Input.GetAxis("Horizontal");
			rigidbody2D.velocity = new Vector2 (move*maxSpeed,rigidbody2D.velocity.y);

			if (move > 0 && !facingRight) {
								Flip ();			
						}
			else if (move < 0 && facingRight)
								Flip ();
        }


     
        private void Flip()
        {
            // Switch the way the player is labelled as facing.
            facingRight = !facingRight;

            // Multiply the player's x local scale by -1.
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}