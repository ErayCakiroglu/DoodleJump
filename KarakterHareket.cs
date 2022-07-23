using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class KarakterHareket : MonoBehaviour
{
    [SerializeField] float hiz;
    [SerializeField] Rigidbody2D doodleHaraket;
    [SerializeField] TextMeshProUGUI skorYazisi;
    int skor;
    float hareketInput;
    void Update()
    {
        hareketInput = Input.GetAxis("Horizontal");
        doodleHaraket.velocity = new Vector2(hareketInput * hiz, doodleHaraket.velocity.y);
        skorYazisi.text = "Skor : " + skor.ToString();
    }

    void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "Bitis")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if(temas.gameObject.tag == "Platform")
        {
            skor += Random.Range(1, 6);
        }
    }
}
