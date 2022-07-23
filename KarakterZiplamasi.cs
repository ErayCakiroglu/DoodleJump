using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterZiplamasi : MonoBehaviour
{

    [SerializeField] float ziplamaGucu;
    Vector2 karakterinHizi;
    Rigidbody2D fizik;

    void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.relativeVelocity.y <= 0 )
        {
            fizik = temas.collider.GetComponent<Rigidbody2D>();

            if(fizik != null)
            {
                karakterinHizi = fizik.velocity;
                karakterinHizi.y = ziplamaGucu;
                fizik.velocity = karakterinHizi;
            }
        }
    }
}
