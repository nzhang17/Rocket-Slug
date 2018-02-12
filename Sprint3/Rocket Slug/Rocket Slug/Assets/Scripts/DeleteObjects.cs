using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObjects : MonoBehaviour 
{   
    void Update()
    {
        if (this.transform.position.y <= -8 && this.gameObject.name == "asteroid(Clone)")
        {
            Destroy(this.gameObject);
        }

        if (this.transform.position.y <= -8 && this.gameObject.name == "fuelTank(Clone)")
        {
            Destroy(this.gameObject);
        }
    }
}
