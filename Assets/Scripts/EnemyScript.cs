using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : SpriteMovement
{
    private void Start()
    {
        InitOnStart();
    }

    private void Update()
    {
        MoveNPC();
    }

}
