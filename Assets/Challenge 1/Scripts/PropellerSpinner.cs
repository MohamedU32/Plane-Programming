using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpinner : MonoBehaviour
{
    [SerializeField] float spinningSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // spin the plane's propeller at constant speed
        transform.Rotate(Vector3.forward, Time.deltaTime * spinningSpeed);
    }
}
