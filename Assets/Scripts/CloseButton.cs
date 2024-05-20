using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
{
    [SerializeField] private Canvas currentCanvas;
    public void CloseCanvas()
    {
        currentCanvas.gameObject.SetActive(false);
    }
}
