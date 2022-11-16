using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceDetector : MonoBehaviour
{
    // Start is called before the first frame update
    public myDetector myDetector;

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            myDetector.should_be_active = true;
        }

    }

}
