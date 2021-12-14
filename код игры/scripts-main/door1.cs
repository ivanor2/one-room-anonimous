//скрипт двери из 4 уровня
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door1 : MonoBehaviour
{
    public GameObject anon;
    public GameObject key1;
    private void Update()
    {
        anon = GameObject.FindGameObjectWithTag("Player");
        key1 = GameObject.FindGameObjectWithTag("ëóíâ");
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            key1.SetActive(false);
            gameObject.SetActive(false);
        }
    }

}


