using UnityEngine;

public class CollisionLogger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo")) // Cambia "Obstaculo" por la tag que asignaste
        {
            Debug.Log("¡El jugador ha chocado con un obstáculo!");
        }
    }
}
