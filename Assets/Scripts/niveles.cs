using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class niveles : MonoBehaviour
{
    public int CofresEnPantalla;
    public GameObject[] NivelPreFab;
    private int IndiceDeNiveles;
    private GameObject ObjetoNivel;
    public Text TextoDeJuego;

    // Start is called before the first frame update
    void Start()
    {
        IndiceDeNiveles = 0;
        ObjetoNivel = Instantiate(NivelPreFab[IndiceDeNiveles]);
        ObjetoNivel.transform.SetParent(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        CofresEnPantalla = this.GetComponentsInChildren<Cofre>().Length;
        TextoDeJuego.text = "\nCreado por Brahian Calle"+
                            "\nNivel " + (IndiceDeNiveles + 1) +
                            "\nDestruye todos los cofres" +
                            "\nCofres restantes: " + CofresEnPantalla;
        if(CofresEnPantalla == 0)
        {
            TextoDeJuego.text = "Nivel Completado! \nPresiona R para pasar al siguiente nivel.";
            Destroy(GameObject.FindWithTag("Bala"));
            Destroy(GameObject.FindWithTag("sonido"));
            if (IndiceDeNiveles == NivelPreFab.Length - 1)
            {
                TextoDeJuego.text = "Completaste los niveles!, \nPreciona R para volver a iniciar";
            }
            if(Input.GetKeyUp("r"))
            {
                if(IndiceDeNiveles == NivelPreFab.Length - 1)
                {
                    Destroy(ObjetoNivel);
                    IndiceDeNiveles = 0;
                    ObjetoNivel = Instantiate(NivelPreFab[0]);
                    ObjetoNivel.transform.SetParent(this.transform);
                }
                else
                {
                    Destroy(ObjetoNivel);
                    IndiceDeNiveles += 1;
                    ObjetoNivel = Instantiate(NivelPreFab[IndiceDeNiveles]);
                    ObjetoNivel.transform.SetParent(this.transform);
                }
            }
        }
    }
}
