using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // textMeshPro eklemekkk için

public class engeller : MonoBehaviour
{
    private static  int skor;
    public TextMeshProUGUI skorYazisi, bitisYazisi;
    
    public AudioSource carpmaSesi;

    private void Start()
    {
        skor = 0;
    }

    private void Update()
    {
        skorYazisi.text = "Skor:" + skor; // yada skorYazisi.text = skor.ToString;
        bitisYazisi.text = "Oyun Bitti ! \n Skor: " + skor.ToString();
    }

    


    private void OnCollisionEnter2D(Collision2D temas)
    {

        float xPozisyonu = Random.Range(-5f, +5f); // engellerin sahneye düþmesi için pozisyon belirliyoruz. ardýndan tekrar yukarýdan düüþmesini tekkrarlýyoruz.
        float yPozisyonu = Random.Range(6f, 15f);

        if (temas.gameObject.tag == "KontrolCubugu")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
            skor += Random.Range(8, 14); // rastgele puan arttýrmak için
        }
        else if(temas.gameObject.tag=="Karakter")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
            skor -= Random.Range(5,10);
            carpmaSesi.Play();
            Can.kalanHak--; 
        }
    
    }


}
