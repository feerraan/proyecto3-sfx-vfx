using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody; // = null
    private float forceMagnitude = 10f;

    private bool isOnTheGround;
    public bool isGameOver;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();

        isOnTheGround = true;
        isGameOver = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround)
        {
            playerRigidbody.AddForce(Vector3.up * forceMagnitude, 
                ForceMode.Impulse);
            isOnTheGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) // Hemos colisionado con el suelo
        {
            isOnTheGround = true;
        }

        if (collision.gameObject.CompareTag("Obstacle")) // Hemos colisionado con un obstáculo
        {
            Debug.Log("GAME OVER");
            isGameOver = true;
        }
    }
}
