using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterToBuilding : MonoBehaviour
{
    [SerializeField] private GameObject tipCanvas;

    private void Start()
    {
        tipCanvas.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnterableBuilding"))
        {
            tipCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("EnterableBuilding"))
        {
            tipCanvas.SetActive(false);
        }
    }
}
