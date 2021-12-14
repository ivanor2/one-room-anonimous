//скрипт для UI "Button" из 2 уровня
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button2 : MonoBehaviour
{
    public Button button;
    public GameObject nextdoor;
    public void sezamotkroysya()
    {
        nextdoor.SetActive(false);
    }




}
