using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2);
        Debug.Log(RetornaElMayorNumero(1, 3, 4));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            EscribeHolaMundo();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EscribirCadenaEnConsola("Cadena");
        }
       
    }
    void EscribeHolaMundo()
    {
        Debug.Log("Hola mundo");
    }
    void EscribirCadenaEnConsola(string cadena)
    {
        Debug.Log(cadena);
    }
    string RetornaElMayorNumero(int num1, int num2, int num3)
    {
        if (num1>num2 && num1 > num3)
        {
            string s1 = num1.ToString();
            return s1;
        }
        else if (num2>num1 && num2>  num3)
        {
            string s2 = num2.ToString();
            return s2;
        }
        else if (num3 > num2 && num3 > num1)
        {
            string s3 = num3.ToString();
            return s3;
        }
        return "-1";
    }
}

   
