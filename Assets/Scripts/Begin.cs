using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour
{
    public TextMeshProUGUI easy;
    public TextMeshProUGUI hard;

    void Start()
    {
        easy.gameObject.SetActive(false);
        hard.gameObject.SetActive(false);
    }


    public void IniciarJuego() 
    {
        SceneManager.LoadScene("Juego");
    }

    public void Dificil()
    {
        if (easy.gameObject.activeSelf)
        {
            easy.gameObject.SetActive(false);
        }
        hard.gameObject.SetActive(true);
    }

    public void Facil()
    {
        if (hard.gameObject.activeSelf)
        {
            hard.gameObject.SetActive(false);
        }
        easy.gameObject.SetActive(true);
    }
}
