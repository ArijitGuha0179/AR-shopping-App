using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class Globals
{
    public static float length = 0.5f;
    public static float breadth = 0.5f;
    public static int i = 1;
};

public class changeTree : MonoBehaviour
{
    
    public GameObject bed;
    public GameObject rotatedBed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RotateBed()
    {
        if (!(Globals.i % 2 == 0))
        {
            bed.SetActive(false);
            rotatedBed.SetActive(true);
            Globals.i++;
        }
        else
        {
            bed.SetActive(true);
            rotatedBed.SetActive(false);
            Globals.i++;
        }    
    }
}
