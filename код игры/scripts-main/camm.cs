//скрипт меню
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camm : MonoBehaviour
{
    public bool pause;
    public GameObject men;
    public Vector3 cammenpos;
    private Camera came;
    public GameObject anon;
    public GameObject[] can;
    public GameObject door;
    public bool inmenu;
    public bool end;
    public Vector3 trupos;
    public GameObject trups;
    public GameObject[] keys;
    public Vector3 kpos1;
    public Vector3 kpos2;
    public Vector3 kpos3;
    public button5 buton;


    void Start()
    {
        came = Camera.main.GetComponent<Camera>();
    }



   
    void Update()
    {
        trups = GameObject.FindGameObjectWithTag("trups");
        anon = GameObject.FindGameObjectWithTag("Player");
        if(inmenu == true)
        { 

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pause = true;
                anon.GetComponent<Rigidbody2D>().simulated = false;
                men.SetActive(true);

            }


    }
        if (inmenu == false)
        {
            if(end == true)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    came.transform.position = cammenpos;
                    otkat();
                }
                    
            }
        }


    }
    public void Onclick()
    {
        anon.GetComponent<Rigidbody2D>().simulated = true;
        men.SetActive(false);
        came.transform.position = cammenpos;
        pause = false;
        can[0].SetActive(false);
        can[1].SetActive(false);
        inmenu = false;
        otkat();
       
        
       

    }
    public void Onclick2()
    {
        men.SetActive(false);
        anon.GetComponent<Rigidbody2D>().simulated = true;
        pause = false;
    }
    public void otkat()
    {
        trupos = trups.transform.position;
        Destroy(trups);
        Instantiate(trups, trupos, Quaternion.identity);
        keys[0].SetActive(true);
        anon.GetComponent<anonimus>().kluchvruke = false;
        anon.GetComponent<anonimus>().key.SetActive(false);
        keys[1].transform.position = kpos2;
        keys[2].transform.position = kpos3;
        buton.rn = 0;
    }



}
