using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temizle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D temas)
    {
        float rastgeleX = Random.Range(-7.5f, 8.5f);
        if(temas.tag == "Platform")
        {
            temas.transform.position = new Vector3(rastgeleX, transform.position.y + 12f, transform.position.z);
        }
    }
}
