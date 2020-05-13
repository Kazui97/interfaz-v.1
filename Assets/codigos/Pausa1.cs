using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pausa1 : MonoBehaviour
{
    bool actvarpanel;
    bool activaropciones;
    Canvas canvaspanel;


    public Text modocamaras;
    public Image botoncamaraprimerapersona;
    public Text botoncamarapp;
    public Button camaraprimerp;

    public Image botonCamaraTp;
    public Text botonterceraPers;
    public Button tercerapersona;

    public Text sonidos;
    public Image sonidosi;
    public Button ssonidos;
    public Text sonidossi;
    public Image nsonidos;
    public Button nosonidos;
    public Text nnosonidos;



    void Start()
    {
        canvaspanel = GetComponent<Canvas>();
        canvaspanel.enabled = false;

        modocamaras.enabled = false;
        botoncamaraprimerapersona.enabled = false;
        botoncamarapp.enabled = false;
        camaraprimerp.enabled = false;

        botonCamaraTp.enabled = false;
        botonterceraPers.enabled = false;
        tercerapersona.enabled = false;

        sonidos.enabled = false;
        sonidosi.enabled = false;
        ssonidos.enabled = false;
        sonidossi.enabled = false;
        nsonidos.enabled = false;
        nosonidos.enabled = false;
        nnosonidos.enabled = false;

    }


    public void panel()
    {
        actvarpanel = !actvarpanel;
        canvaspanel.enabled = actvarpanel;
    }
    public void opciones()
    {
        activaropciones = !activaropciones;
        modocamaras.enabled = activaropciones;
        botoncamaraprimerapersona.enabled = activaropciones;
        botoncamarapp.enabled = activaropciones;
        camaraprimerp.enabled = activaropciones;

        botonCamaraTp.enabled = activaropciones;
        botonterceraPers.enabled = activaropciones;
        tercerapersona.enabled = activaropciones;

        sonidos.enabled = activaropciones;
        sonidosi.enabled = activaropciones;
        ssonidos.enabled = activaropciones;
        sonidossi.enabled = activaropciones;
        nsonidos.enabled = activaropciones;
        nosonidos.enabled = activaropciones;
        nnosonidos.enabled = activaropciones;

    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel();
        }
    }
}
