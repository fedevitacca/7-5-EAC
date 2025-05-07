using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script2 : MonoBehaviour
{
    public int num1;
    public int num2;
    public TMP_InputField InputNum1;
    public TMP_InputField InputNum2;
    public TextMeshProUGUI textResultado;

    // Start is called before the first frame update
    void Start()
    {
        textResultado.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DividirYMostrarResultado()
    {
        //tomar los valores del input y sumarlos
        num1 = int.Parse(InputNum1.text);
        num2 = int.Parse(InputNum2.text);

        textResultado.text = $"{num1 / num2}";
    }


}