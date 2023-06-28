using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veggie : MonoBehaviour
{

    private State active;

    private Rigidbody rb;

    [SerializeField]
    private float walkSpeed = 5f;

    public float WalkSpeed
    {
        get
        {
            return walkSpeed;
        }
    }

    public Rigidbody Rb
    {
        get { return rb; }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        active = new WanderState(this);
    }

    // Update is called once per frame
    void Update()
    {
        active.UpdateState();
    }

    public void ChangeState(State newState)
    {
        active = newState;
    }
}
