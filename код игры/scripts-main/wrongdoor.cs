//скрипт двери из 9 уровня
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrongdoor : MonoBehaviour
{
    private int hz;
    public GameObject door;
    public GameObject buton;
    public void onclick()
    {
        hz++;
        if (hz > 3)
        {
            door.SetActive(false);
            buton.SetActive(false);


        }
    }
}
