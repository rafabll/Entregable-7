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
        ShowMessage (KeyCode.RightArrow, "Derecha");
        ShowMessage (KeyCode.LeftArrow, "Izquierda");
        ShowMessage (KeyCode.UpArrow, "Arriba");
        ShowMessage (KeyCode.DownArrow, "Abajo");
        ShowMessage (KeyCode.Space, "Booing");
    }
    public void ShowMessage(KeyCode key, string message)
    {
        if (Input.GetKeyDown(key))
        {
            ImageText.text = message;
        }
    }
}