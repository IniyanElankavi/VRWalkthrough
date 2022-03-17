using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    public Light[] _lights;
    bool lightSwitch = false;

    private void Start()
    {
        _lights = GameObject.Find("Interior").GetComponentsInChildren<Light>();
    }

    public void TurnOnOffLight()
    {
        lightSwitch =! lightSwitch;

        for (int i = 0; i < _lights.Length; i++)
        {
            if (lightSwitch)
            {
                _lights[i].enabled = false;
            }
            else
            {
                _lights[i].enabled = true;
            }
        }
    }

}
