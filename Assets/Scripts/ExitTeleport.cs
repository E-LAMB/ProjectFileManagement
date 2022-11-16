using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTeleport : MonoBehaviour
{

    public int teleport_to = 0;
    public bool should_be_active = false;

    public GameObject activator;

    public GameObject playerChecker;
    public LayerMask playerLayer;
    public float distance_required = 1.0f;

    bool is_close;

    // Start is called before the first frame update
    void LoadingScript()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(teleport_to);
    }

    void update()
    {

        should_be_active = activator.GetComponent<StandingButtonActivator>().RequestState();

        if (should_be_active == true)
        {
            LoadingScript();
        }
    }
}
