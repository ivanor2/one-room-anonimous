//скрипт переходника
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perehod : MonoBehaviour
{
    public Vector3 cameraChangePos;
    public Vector3 playerChangePos;
    private Camera cam;
    public GameObject[] canvas;
    public camm camm;
    public GameObject door;
    public GameObject anon;
    public camd cumd;
    public GameObject unlvl;
    public bool end;
    public bool lvl;
   
    
    void Start()
    {
        cam = Camera.main.GetComponent<Camera>();
    }
    private void Update()
    {
        anon = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            other.transform.position += playerChangePos;
            cam.transform.position += cameraChangePos;
            if (end == true)
            {
                camm.inmenu = false;
                camm.end = true;
            }
            if (lvl == true) 
            {
                cumd.lvl = true;
            }
            canvas[0].SetActive(false);
            canvas[1].SetActive(false);
            canvas[2].SetActive(true);
            canvas[3].SetActive(true);
            camm.can[0] = canvas[2];
            camm.can[1] = canvas[3];
            cumd.camPos = cam.transform.position;
            cumd.can[0] = canvas[2];
            cumd.can[1] = canvas[3];
            cumd.door = door;
            cumd.anonpos = anon.transform.position;
            
            unlvl.SetActive(true);
            
                

            





        }
    }

}
