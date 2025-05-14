using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script3 : MonoBehaviour
{

    public TMP_InputField InputNum1;
    public TextMeshProUGUI Resultado;
    int num1;

    // Start is called before the first frame update
    void Start()
    {
        Resultado.text = "";
    }
    
    public void ParImpar()
    {
        if(InputNum1.text == "")
        {
            Resultado.text = "El campo esta vacío";
            return;
        }

        num1 = int.Parse(InputNum1.text);

        if(num1 <= 0)
        {
            Resultado.text = "El número debe ser mayor a cero";
            return;
        }

        if(num1 % 2 == 0)
        {
            Resultado.text = "El número es par";
        }
        else
        {
            Resultado.text = "El número es impar";
        }

    }
}
