//скрипт обычной кнопки
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button11 : MonoBehaviour
{
    public GameObject button;
   public GameObject door;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            button.SetActive(false);
            door.SetActive(false);
            
        }
       
        

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            button.SetActive(true);
        }
    }


}
