using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogInManager : MonoBehaviour
{

    string rightPassword = "julo";
    public InputField inputField;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void checkLogIn(string password, string input)
    {
        if (input == password)
        {
            Debug.Log("Contraseña Correcta");
        }
        else
        {
            Debug.Log("Contraseña Incorrecta");
        }
    }

    public void buttonClick()
    {
        checkLogIn(rightPassword, inputField.text);
    }
}
