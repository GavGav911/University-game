using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconBehaviour : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Canvas canvas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            image.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            image.enabled = false;
        }
    }

    private void FixedUpdate()
    {
        if (image.enabled && Input.GetKey(KeyCode.E))
        {
            canvas.gameObject.SetActive(true);
        }
    }
}
