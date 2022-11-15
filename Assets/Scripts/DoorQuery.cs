using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorQuery : MonoBehaviour
{

    // THIS SCRIPT ALLOWS FOR DOORS TO QUESTION THE ACTIVE STATE OF ANY OBJECT. WHILE INACTIVE, IT WILL BE CLOSED. WHILE ACTIVE IT WILL BE OPEN.

    public bool should_be_active = false; // If the door should be active

    public Transform player;

    public Vector3 inactive_location; // Where the door should be when not activated (Both of these refer to Y position)
    public Vector3 active_location; // Where the door should be when activated

    public GameObject activator; // What activates this object

    public int activator_type = 0; // What type of activator is it?
    // 1 - Permanent Button
    // 2 - Standing Button
    // 3 - Timed Button //

    Vector3 moving_position;

    // Update is called once per frame
    void FixedUpdate()
    {

        if (activator_type == 1)
        {
            should_be_active = activator.GetComponent<PermaButtonActivator>().RequestState();
        }

        if (should_be_active == true)
        {
            transform.position = active_location;
        }

        if (should_be_active == false)
        {
            transform.position = inactive_location;
        }

    }

}
