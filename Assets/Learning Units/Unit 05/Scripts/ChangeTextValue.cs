using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeTextValue : MonoBehaviour
{
    // DIRECTIONS: The goal of this script is to show the Y coordinate of the cube on
    // the screen. You will need to add some stuff to this script to make it work...
    [SerializeField] GameObject obj;

    TextMeshProUGUI textMeshProUGUI;

    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        textMeshProUGUI.text = obj.transform.position[1].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = obj.transform.position[1].ToString();
    }
}
