using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioControl : MonoBehaviour
{
    public GameObject audiomenu;
    
    public void AudiOn()
    {
        AudioListener.volume = 1;
    }

    public void AudiOf()
    {
        AudioListener.volume = 0;
    }
}
