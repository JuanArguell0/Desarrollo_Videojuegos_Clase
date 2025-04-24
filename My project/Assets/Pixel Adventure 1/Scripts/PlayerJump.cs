using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 10f; // Aumentamos la fuerza del salto
    private Rigidbody2D playerRigidbody;
    private bool isGrounded;

    void Start()
    {
        // Obtener el Rigidbody2D del personaje (el objeto padre)
        playerRigidbody = GetComponentInParent<Rigidbody2D>();
        
    }

    void Update()
    {
        // Verificar si el jugador presiona el botón de salto y está en el suelo
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            playerRigidbody.linearVelocity = new Vector2(playerRigidbody.linearVelocity.x, jumpForce);
            isGrounded = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
