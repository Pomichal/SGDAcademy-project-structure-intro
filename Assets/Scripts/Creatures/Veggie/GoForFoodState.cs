using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoForFoodState : State
{

    private Vector3 targetPosition;

    public GoForFoodState(Veggie sm, Vector3 target) : base(sm)
    {
        targetPosition = target;
    }

    public override void UpdateState()
    {
        Vector3 dir = (targetPosition - veggie.transform.position).normalized;
        dir = new Vector3(dir.x, 0, dir.z);
        veggie.Rb.MovePosition(veggie.transform.position + dir * Time.deltaTime * veggie.WalkSpeed);
        // TODO: check, if I reached the target, eat the food and change state
    }
}
