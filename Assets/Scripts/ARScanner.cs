using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARScanner : MonoBehaviour
{
    // Scanear la imagen del mapa para visualizar los distintos monumentos

    private Camera arCamera;
    private ARSession arSession;

    private void Start()
    {
        arCamera = GetComponent<Camera>();
        arSession = FindObjectOfType<ARSession>();
    }

    public void EnableAR()
    {
        arCamera.enabled = true;
        arSession.enabled = true;
    }

    public void DisableAR()
    {
        arCamera.enabled = false;
        arSession.enabled = false;
    }
    
}
