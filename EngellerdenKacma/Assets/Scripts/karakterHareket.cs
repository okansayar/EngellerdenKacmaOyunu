using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterHareket : MonoBehaviour
{
    public float hareketHizi;

    void Start()
    {
        
    }

   
    void Update()
    {

        float hiz =hareketHizi * Input.GetAxis("Horizontal"); //yatay hýzda 
        transform.Translate(hiz * Time.deltaTime, 0, 0);
        

    }
}
