﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{

    public Sprite Pressed;

    [SerializeField] private PolygonCollider2D[] colliders;
    private int currentColliderIndex = 0;
    internal bool isPressed;

    public void Start()
    {
        colliders[currentColliderIndex].enabled = true;
        isPressed = false;
    }

    public void SetColliderForSprite(int spriteNum)
    {
        colliders[currentColliderIndex].enabled = false;
        currentColliderIndex = spriteNum;
        colliders[spriteNum].enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = Pressed;
        isPressed = true;
        SetColliderForSprite(1);
    }
}