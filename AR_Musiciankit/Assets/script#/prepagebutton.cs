using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class prepagebutton : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject vbButtonObject;

    public ChangeTexture m_ChangeTextureScript;

    // Use this for initialization
    void Start()
    {

        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {

        Debug.Log("Button down!!!");

        m_ChangeTextureScript.PreviousTexture();

    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
    }
}