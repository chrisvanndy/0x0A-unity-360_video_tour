using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoToggle : MonoBehaviour
{
    public GameObject InfoPanel;

    // Start is called before the first frame update
    public void infoToggle()
    {
        if (InfoPanel != null)
        {
            bool isActive = InfoPanel.activeSelf;

            InfoPanel.SetActive(!isActive);
        }
    }
}
