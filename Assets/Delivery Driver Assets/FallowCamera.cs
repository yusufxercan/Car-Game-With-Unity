using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingsFallow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingsFallow.transform.position + new Vector3 (0, 0, -10);
    }
}
