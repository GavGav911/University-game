using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlantTimer : MonoBehaviour
{
    private float time = 0f;
    private bool grown;
    [SerializeField] private Sprite notGrown;
    [SerializeField] private Sprite halfGrown;
    [SerializeField] private Sprite fullGrown;
    private SpriteRenderer spriteRenderer;
    
    private bool bought = false;

    private void OnEnable()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = notGrown;
        StartTimer();
    }

    private void FixedUpdate()
    {
        Debug.Log(time);
        if (!grown)
        {
            time += Time.deltaTime;
        }
        ChangeSprite();
    }

    private void ChangeSprite()
    {
        if (time >= 15f && time < 30f)
        {
            spriteRenderer.sprite = halfGrown;
        }

        if (time >= 30f)
        {
            spriteRenderer.sprite = fullGrown;
            StopTimer();
        }
    }

    private void StartTimer()
    {
        time = 0;
    }
    private void StopTimer()
    {
        time = 0;
        grown = true;
    }

    public void BuyButtom()
    {
        if (!bought)
        {
            gameObject.SetActive(true);
            bought = true;
        }
    }

    public void SellButton()
    {
        if (grown)
        {
            gameObject.SetActive(false);
            grown = false;
            bought = false;
        }
    }
}
