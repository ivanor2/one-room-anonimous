//скрипт шипа
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{
    public door1 door;
    public GameObject player;
    public GameObject rpos;
    public GameObject clone;
    public GameObject trup;
    public Vector3 kpos;
    public GameObject key;
    public GameObject trups;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            player = Instantiate(player, rpos.transform.position, Quaternion.identity);
            Instantiate(trup, transform.position, Quaternion.identity,trups.transform);
            key.transform.position = kpos;

        }
    }
    public void Update()
    {
        trups = GameObject.FindGameObjectWithTag("trups");
        player = GameObject.FindGameObjectWithTag("Player");
        player.name = "anon";
        player.GetComponent<Animator>().enabled = true;
        player.GetComponent<anonimus>().enabled = true;
        player.GetComponent<CapsuleCollider2D>().enabled = true;
       
        
        
        

        


    }
}
