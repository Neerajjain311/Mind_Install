using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThicknessChange : MonoBehaviour
{
    // Start is called before the first frame update
    public LineSettings l;
    void Start()
    {
        l.startWidth = 0.003f;
        l.endWidth = 0.003f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Thickness(float val)
    {
        l.startWidth = val;
        l.endWidth = val;
    }
}
