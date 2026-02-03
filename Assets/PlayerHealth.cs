using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Player died");
    }
}
