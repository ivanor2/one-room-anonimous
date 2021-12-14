//скрипт кнопки из 5 уровня
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button4 : MonoBehaviour
{

    public GameObject button;
    public GameObject door;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("ëóí"))
        {
            button.SetActive(false);
            door.SetActive(false);
        }


    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("ëóí"))
        {
            button.SetActive(true);
        }


    }
}
