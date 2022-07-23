using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeviyeOlusturucu : MonoBehaviour
{

    [SerializeField] GameObject platformObjesi;
    [SerializeField] int platformSayisi;
    [SerializeField] float minX, maxX, minY, maxY;
    void Start()
    {
        Vector3 klonPozisyonu = new Vector3();

        for(int i = 0; i < platformSayisi; i++)
        {
            klonPozisyonu.x = Random.Range(minX, maxX);
            klonPozisyonu.y = Random.Range(minY, maxY);
            Instantiate(platformObjesi, klonPozisyonu, Quaternion.identity);
        }
    }
}
