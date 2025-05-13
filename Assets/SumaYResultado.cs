using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    

public class SumaYResultado : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_InputField ImputNum1;
    public TMP_InputField ImputNum2;
    public TextMeshProUGUI TxtResultado;
    int num1;
    int num2;
    void Start()
    {
        TxtResultado.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SumarYMostrar()
    {

    }
}
