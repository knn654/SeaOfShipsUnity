using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Perks : MonoBehaviour
{
    private GameManager gameManager; // Referência ao GameManager

    // Start is called before the first frame update
    void Start()
    {
       gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void doisTiros()
    {
        Debug.Log("Testando - Dois Tiros");
    }

    public void tiroAleatorio()
    {
        Debug.Log("Testando - Tiro Aleatório");
    }

    public void escudo()
    {
        Debug.Log("Testando - Escudo");
    }
}
