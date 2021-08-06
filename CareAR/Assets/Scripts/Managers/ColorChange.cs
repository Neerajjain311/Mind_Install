using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    public LineSettings l;
    void Start()
    {
        l.startColor = Color.white;
        l.endColor = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ColorWhite()
    {
        l.startColor = Color.white;
        l.endColor = Color.white;
    }

    public void ColorRed()
    {
        l.startColor = new Color32(195, 10, 40, 255);
        l.endColor = new Color32(195, 10, 40, 255); ;
    }

    public void ColorYellow()
    {
        l.startColor = new Color32(233,255,50,255);
        l.endColor = new Color32(233, 255, 50, 255);
    }

    public void ColorBlack()
    {
        
        l.startColor = Color.black;
        l.endColor = Color.black;
    }
}
