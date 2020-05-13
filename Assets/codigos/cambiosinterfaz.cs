using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cambiosinterfaz : MonoBehaviour
{
    // jugar
    bool activarbotonjuego;
    Canvas Canvas;
    public Image jugartutorial;
    public Button botontutorial;
    public Text jugartuto;
    public Image jugarlocal;
    public Text jugaarlocal;
    public Button botonjugarlocal;
    


    //opciones
    bool activaropciones;
    public Image opcionesmusica;
    public Text Musica;
    public Text smusica;
    public Button simusica;
    public Text nmusica;
    public Button nomusica;
    public Image nomusic;
    

    



    
    void Start()
    {
        Canvas = GetComponent<Canvas>();

        jugartutorial.enabled = false;
        botontutorial.enabled = false;
        jugaarlocal.enabled = false;
        jugarlocal.enabled = false;
        botonjugarlocal.enabled = false;
        jugartuto.enabled = false;

        opcionesmusica.enabled = false;
        smusica.enabled = false;
        simusica.enabled = false;
        Musica.enabled = false;
        nmusica.enabled = false;
        nomusica.enabled = false;
        nomusic.enabled = false;
    }

    
    void Update()
    {
        
    }


    public void Juego()
    {
        activarbotonjuego = !activarbotonjuego;
        jugartutorial.enabled = activarbotonjuego;
        botontutorial.enabled = activarbotonjuego;
        jugartuto.enabled = activarbotonjuego;
        jugarlocal.enabled = activarbotonjuego;
        botonjugarlocal.enabled = activarbotonjuego;
        jugaarlocal.enabled = activarbotonjuego;

    }

    public void opcion()
    {
        activaropciones = !activaropciones;
        opcionesmusica.enabled = activaropciones;
        smusica.enabled = activaropciones;
        simusica.enabled = activaropciones;
        Musica.enabled = activaropciones;
        nmusica.enabled = activaropciones;
        nomusica.enabled = activaropciones;
        nomusic.enabled = activaropciones;
    }

}
