using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatcherTeleport : MonoBehaviour
{

    public GameObject activator; // What initiates chasing mode?

    public Transform watcher; // This is the Watcher's position
    public Transform player; // This is the Player's position

    public float max_cooldown = 4.0f; // How long between each teleport
    public float max_distance = 5.0f; // How far each teleport can reach

    public float cooldown;

    // Start is called before the first frame update
    void Start()
    {
        cooldown = max_cooldown;
    }

    // Update is called once per frame
    void Update()
    {

        player.position.y = watcher.position.y;
        
        if (cooldown < 0)
        {
            watcher.position = Vector3.MoveTowards(watcher.position, player.position, max_distance);
            cooldown = max_cooldown;
        } 

        cooldown = cooldown - Time.deltaTime;

    }
}
