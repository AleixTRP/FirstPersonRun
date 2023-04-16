using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    public TextMeshProUGUI pointstext;
    private int points = 0;
    public AudioClip GetCoin;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().PlayOneShot(GetCoin);
            MorePoints.PlusPoints();
            pointstext.text = "Points: " + MorePoints.points.ToString() + "/10";

            if (MorePoints.points >= 10)
            {
                Application.Quit();
            }           
            gameObject.GetComponent<Light>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}


