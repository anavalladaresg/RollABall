using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player; // Guarda el jugador al que va a seguir la camara
    private Vector3 offset; // Guardar la distancia entre la cámara y el jugador
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position; // Distancia entre la cámara y el jugador
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset; // Actualizamos la posición de la cámara para que siga al jugador
    }
}