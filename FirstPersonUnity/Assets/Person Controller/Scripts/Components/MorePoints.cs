using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorePoints : MonoBehaviour
{
    public static int points = 0;

    private void Start()
    {
       
    }

    public static void PlusPoints()
    {
        points++;
        
    }
}