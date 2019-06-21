using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killplayer2 : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            col.transform.position = spawnPoint.position;
            



        }
    }
}
