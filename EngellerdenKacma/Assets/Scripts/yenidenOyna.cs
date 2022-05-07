using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yenidenOyna : MonoBehaviour
{
    
   public void YenidenOyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Can.kalanHak = 3;
        Time.timeScale = 1;
    }
}
