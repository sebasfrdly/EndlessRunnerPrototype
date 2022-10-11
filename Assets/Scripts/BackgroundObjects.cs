using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BackgroundObjects : SpriteMovement
{
    public Sprite[] cloudSpirtes;
    public SpriteRenderer spriteRenderer;
    public int spriteNum;

    private void Awake()
    {
        InitOnStart();

        //gets the sprite from our sprite array
        spriteNum = Random.Range(0, 5);

        //gets reference to the current object's sprite renderers
        spriteRenderer = this.GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = cloudSpirtes[spriteNum];
    }

    private void Update()
    {
        MoveNPC();
    }


}

