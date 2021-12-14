//скрипт кнопки из 8 уровня
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button5 : MonoBehaviour
{
    public int rn = 0;
    public GameObject pol;
    public GameObject strelka;
    public GameObject button;
    public void OnTriggerEnter2D(Collider2D other )
    {
        if(other.CompareTag("Player"))
        {
            button.SetActive(false);
            rn++;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            button.SetActive(true);
        }
    }
    public void Update()
    {
        if(rn >= 3)
        {
            pol.SetActive(false);
            strelka.SetActive(true);
        }
        else if(rn == 0)
        {
            pol.SetActive(true);
            strelka.SetActive(false);
        }
    }

}
