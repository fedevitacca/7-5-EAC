using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script4 : MonoBehaviour
{

    public TextMeshProUGUI txtResultado;
    public TMP_InputField inputCodigo;
    public TMP_InputField inputDias;
    string codigo;
    int cantDias;
    int comidaPerrosPeque = 400;
    int comidaPerrosGrandes = 700;
    int comidaGatos = 300;
    int comidaAnimalIndicado;
    int comidaTotal;
    float precioPorCienGramos = 80;
    float precioTotal;

    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";
    }

    public void calcularComida()
    {
        if (inputDias.text == string.Empty)
        { 
            txtResultado.text = "Debe ingresar un dato";
            return;
        }
        if (inputCodigo.text == string.Empty)
        {
            txtResultado.text = "Debe ingresar un dato";
            return;
        }

        codigo = inputCodigo.text;
        cantDias = int.Parse(inputDias.text);

        if (cantDias < 3)
        {
            txtResultado.text = "La cantidad de dias no puede ser menor a 3";
            return;
        }
        if (codigo != "G" && codigo != "PP" && codigo != "PG")
        {
            txtResultado.text = "Codigo no valido";
            return;
        }

        if (codigo == "G")
        {
            comidaAnimalIndicado = comidaGatos;
        } else if (codigo == "PP")
        {
            comidaAnimalIndicado = comidaPerrosPeque;
        } else if (codigo == "PG")
        {
            comidaAnimalIndicado = comidaPerrosGrandes;
        } else
        {
            txtResultado.text = "Codigo no valido";
            return;
        }

        comidaTotal = comidaAnimalIndicado * cantDias;
        precioTotal = (comidaTotal / 100) * precioPorCienGramos;


        txtResultado.text = "Para ese periodo se necesitan " + comidaTotal + " gramos de alimento, que saldrán " + precioTotal + " $"; 
    }
    
}
