//скрипт главного меню
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camd : MonoBehaviour
{
    public Vector3 camPos;
    public Vector3 lvlpos;
    private Camera cam;
    public GameObject[] can;
    public GameObject anon;
    public Vector3 anonpos;
    public GameObject door;
    public camm cum;
    public GameObject[] doors;
    public bool lvl;

    void Start()
    {
        cam = Camera.main.GetComponent<Camera>();
    }
    public void onclick()
    {
        
        anon = GameObject.FindGameObjectWithTag("Player");
        anon.transform.position = anonpos;
        cam.transform.position = camPos;
        cum.inmenu = true;      
        can[0].SetActive(true);
        can[1].SetActive(true);
        if (lvl == true)
        {
            doors[0].SetActive(true);
            doors[1].SetActive(true);
            doors[2].SetActive(true);
            doors[3].SetActive(true);

        }
        door.SetActive(true);




    }
    public void onclick2()
    {
        cam.transform.position = lvlpos;
        
    }
    public void onclick3()
    {
        Application.Quit();
    }


}
