using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderState : State
{

    private Vector3 dir;

    public WanderState(Veggie stateMachine) : base(stateMachine)
    {
        dir = GetDir();
    }

    public override void UpdateState()
    {
        veggie.Rb.MovePosition(veggie.transform.position + dir * Time.deltaTime * veggie.WalkSpeed);

        RaycastHit hit;

        if(Physics.Raycast(veggie.transform.position, dir, out hit, 1))
        {
            if(hit.collider.gameObject.CompareTag("Blocking") || hit.collider.gameObject.CompareTag("Veggie"))
            {
                dir = GetDir();
            }
        }

        for(int i = -60; i <= 60; i+=15)
        {
            Vector3 lookDir = Quaternion.AngleAxis(i, Vector3.up) * dir;
            if(Physics.Raycast(veggie.transform.position, lookDir, out hit, 4.5f))
            {
                if(hit.collider.gameObject.CompareTag("Food"))
                {
                    veggie.ChangeState(new GoForFoodState(veggie, hit.collider.gameObject.transform.position));
                }
            }
        }
    }


    private Vector3 GetDir()
    {
        return new Vector3(Random.Range(-1, 1f), 0, Random.Range(-1, 1f)).normalized;
    }
}
