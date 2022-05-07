using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Can : MonoBehaviour
{
    public static int kalanHak = 3; // engellerde �a��rabilmekk i�in static yap�yoruz
    public TextMeshProUGUI hakYazisi;

    public GameObject bitisPaneli;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hakYazisi.text = "hak:" + kalanHak.ToString();

        if (kalanHak == 0)
        {
            bitisPaneli.SetActive(true); // paneli aktif etmek i�in
            Time.timeScale = 0;
        }
    }
}
