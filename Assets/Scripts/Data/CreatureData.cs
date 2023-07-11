using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureData
{
    public string creatureName;
    public float walkSpeed;

    public CreatureData(string name, float speed)
    {
        creatureName = name;
        walkSpeed = speed;
    }
}
