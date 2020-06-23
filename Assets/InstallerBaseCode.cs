using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstallerBaseCode : MonoBehaviour
{
    public Canvas baseCanvas;
    void Start()
    {
        try
        {

            baseCanvas.GetComponent<CanvasScaler>().scaleFactor = Screen.dpi / 100f;
        }
        catch (System.Exception)
        {
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
