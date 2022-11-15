using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermaButtonActivator : MonoBehaviour
{

    // THIS SCRIPT ALLOWS A PERMANENT BUTTON WHICH SENDS AN ACTIVE STATE WHEN PRESSED

    public bool active_state = false;

    public GameObject playerChecker;
    public LayerMask playerLayer;

    public float distance_required = 1.0f;

    bool is_close;

    // Update is called once per frame
    void Update()
    {

        is_close = Physics.CheckSphere(playerChecker.transform.position, distance_required, playerLayer);

        if (Input.GetKeyDown(KeyCode.Alpha0) && is_close == true)
        {
            active_state = true;
        }
    }

    public bool RequestState()
    {
        return active_state;
    }
}
