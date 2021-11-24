using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class play : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject Play;


	// Use this for initialization
    void Start()
    {

        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {

        Debug.Log("playyyyyy!");



        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("off!");
    }
}