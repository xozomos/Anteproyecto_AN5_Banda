using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject panelOriginal;
    public GameObject panelPaletizado;

    public void MostrarPaletizado()
    {
        panelOriginal.SetActive(false);
        panelPaletizado.SetActive(true);
    }

    public void MostrarOriginal()
    {
        panelOriginal.SetActive(true);
        panelPaletizado.SetActive(false);
    }
}
