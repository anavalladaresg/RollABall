using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Estado
{
    Quieto, 
    Movimiento,
    Volando,
    Muerto
}

public class Estados : StateMachineBehaviour
{
    public Estado estado;

    void update() {
        switch (estado)
        {
            case Estado.Quieto:
                Debug.Log("Estoy quieto");
                break;
            case Estado.Movimiento:
                Debug.Log("Estoy en movimiento");
                break;
            case Estado.Volando:
                Debug.Log("Estoy volando");
                break;
            case Estado.Muerto:
                Debug.Log("Estoy muerto");
                break;
            default:
                Debug.Log("Estado no reconocido");
                break;
        }
    }

    void cambiarEstado(Estado nuevoEstado) {
        estado = nuevoEstado;
    }
}
