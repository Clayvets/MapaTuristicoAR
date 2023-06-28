using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARController : MonoBehaviour
{
    //Cuando se selecciona un edificio los demas se ocultan y este se escala
    public List<GameObject> objects;

    private float originalScale;

    private void Start()
    {
        // Guardar la escala original del primer objeto de la lista
        originalScale = objects[0].transform.localScale.x;
    }

    public void SelectObject(int index)
    {
        // Activar el objeto seleccionado y desactivar los demás
        for (int i = 0; i < objects.Count; i++)
        {
            objects[i].SetActive(i == index);
        }

        // Escalar el objeto seleccionado al 150% de su tamaño original
        objects[index].transform.localScale = new Vector3(originalScale * 1.5f, originalScale * 1.5f, originalScale * 1.5f);
    }

}
