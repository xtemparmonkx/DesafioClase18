using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{
    [SerializeField] public float Damage = 20f;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "caja") // Si la bala colisiona con una caja, se destruye
        {
            Debug.Log("La bala colisionĂ³ con una caja");
            Destroy(this.gameObject);

        }

        if (collision.gameObject.tag == "bullet") // Si la bala colisiona con otra bala, se destruye
        {
            Debug.Log("La bala colisionĂ³ con una caja");
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Enemy") // Si la bala colisiona con un enemigo, se destruye
        {
            Debug.Log("La bala colisionĂ³ con un enemigo");
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Player") // Si la bala colisiona con otra bala, se destruye
        {
            Debug.Log("La bala colisionĂ³ con player");
            Destroy(this.gameObject);
        }
    }

    

}
