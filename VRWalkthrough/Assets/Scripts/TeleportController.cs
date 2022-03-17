using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour
{
    public GameObject Player;

    public void Teleport()
    {
        Player.transform.position = new Vector3(transform.position.x, transform.position.y+1.3f,transform.position.z);
    }
}
