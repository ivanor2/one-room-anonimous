//скрипт меню уровней
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    private Camera cum;
    public camm cumd;
    public camd cumm;
    public Vector3 lvl1pos;
    public Vector3 lvl2pos;
    public Vector3 lvl3pos;
    public Vector3 lvl4pos;
    public Vector3 lvl5pos;
    public Vector3 lvl6pos;
    public Vector3 lvl7pos;
    public Vector3 lvl8pos;
    public Vector3 lvl9pos;
    public Vector3 lvl10pos;
    public GameObject[] canv;
    public GameObject[] prppos;
    public GameObject anon;
    public GameObject[] doors;
    void Start()
    {
        cum = Camera.main.GetComponent<Camera>();
    }
    private void Update()
    {
        anon = GameObject.FindGameObjectWithTag("Player");
    }

    public void onclickn()
    {
        cum.transform.position = cumd.cammenpos;

    }
    public void onclick1()
    {
        cum.transform.position = lvl1pos;
        canv[0].SetActive(true);
        anon.transform.position = prppos[0].transform.position;
        cumd.inmenu = true;
        cumm.camPos = cum.transform.position;
        cumm.anonpos = anon.transform.position;
        doors[0].SetActive(true);

    }
    public void onclick2()
    {
        cum.transform.position = lvl2pos;
        canv[1].SetActive(true);
        canv[2].SetActive(true);
        anon.transform.position = prppos[1].transform.position;
        cumd.inmenu = true;
        cumm.camPos = cum.transform.position;
        cumm.anonpos = anon.transform.position;
        doors[1].SetActive(true);

    }
    public void onclick3()
    {
        cum.transform.position = lvl3pos;
        canv[3].SetActive(true);
        anon.transform.position = prppos[2].transform.position;
        cumd.inmenu = true;
        cumm.camPos = cum.transform.position;
        cumm.anonpos = anon.transform.position;
        doors[2].SetActive(true);
    }
    public void onclick4()
    {
        cum.transform.position = lvl4pos;
        canv[4].SetActive(true);
        anon.transform.position = prppos[3].transform.position;
        cumd.inmenu = true;
        cumm.camPos = cum.transform.position;
        cumm.anonpos = anon.transform.position;
        doors[3].SetActive(true);
    }
    public void onclick5()
    {
        cum.transform.position = lvl5pos;
        canv[5].SetActive(true);
        anon.transform.position = prppos[4].transform.position;
        cumd.inmenu = true;
        cumm.camPos = cum.transform.position;
        cumm.anonpos = anon.transform.position;
        doors[4].SetActive(true);
    }
    public void onclick6()
    {
        cum.transform.position = lvl6pos;
        canv[6].SetActive(true);
        anon.transform.position = prppos[5].transform.position;
        cumd.inmenu = true;
        cumm.camPos = cum.transform.position;
        cumm.anonpos = anon.transform.position;
        doors[5].SetActive(true);
    }
    public void onclick7()
    {
        cum.transform.position = lvl7pos;
        canv[7].SetActive(true);
        anon.transform.position = prppos[6].transform.position;
        cumd.inmenu = true;
        cumm.camPos = cum.transform.position;
        cumm.anonpos = anon.transform.position;
        doors[6].SetActive(true);
    }
    public void onclick8()
    {
        cum.transform.position = lvl8pos;
        canv[8].SetActive(true);
        anon.transform.position = prppos[7].transform.position;
        cumd.inmenu = true;
        cumm.camPos = cum.transform.position;
        cumm.anonpos = anon.transform.position;
        doors[7].SetActive(true);
    }
    public void onclick9()
    {
        cum.transform.position = lvl9pos;
        canv[9].SetActive(true);
        anon.transform.position = prppos[8].transform.position;
        cumd.inmenu = true;
        cumm.camPos = cum.transform.position;
        cumm.anonpos = anon.transform.position;
        doors[8].SetActive(true);
        doors[9].SetActive(true);

    }
    public void onclick10()
    {
        cum.transform.position = lvl10pos;
        canv[10].SetActive(true);
        anon.transform.position = prppos[9].transform.position;
        cumd.inmenu = true;
        cumm.camPos = cum.transform.position;
        cumm.anonpos = anon.transform.position;
        doors[10].SetActive(true);
        doors[11].SetActive(true);
        doors[12].SetActive(true);
        doors[13].SetActive(true);




    }
}
