using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private string screenMessage;
    public TextMeshProUGUI ImageText;

    // Start is called before the first frame update
    void Start()
    {
        screenMessage = "Pulsa cualquiera de las cuatro flechas";
        ImageText.text = screenMessage;
    }

    // Update is called once per frame
    void Update()
    {
        ShowMessage (screenMessage, KeyCode.RightArrow);
        ShowMessage (screenMessage, KeyCode.LeftArrow);
        ShowMessage (screenMessage, KeyCode.UpArrow);
        ShowMessage (screenMessage, KeyCode.DownArrow);
        ShowMessage (screenMessage, KeyCode.Space);
    }
    public void ShowMessage(string message, KeyCode key)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            screenMessage = "Derecha";
            ImageText.text = message;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            screenMessage = "Izquierda";
            ImageText.text = message;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            screenMessage = "Arriba";
            ImageText.text = message;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {


            screenMessage = "Abajo";
            ImageText.text = message;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            screenMessage = "SShhh";
            ImageText.text = message;
        }
    }
}