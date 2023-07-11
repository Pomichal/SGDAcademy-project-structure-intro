using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureManager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        CreatureData data = JsonParser.Deserialize<CreatureData>("{'creatureName':'asdf', 'walkSpeed':5}");
        Debug.Log(data);
        Debug.Log(data.creatureName);
        Debug.Log(data.walkSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
