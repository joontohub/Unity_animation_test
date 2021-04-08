using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject lightObject;
    private Light objectLight;
    private void Start() {
      objectLight   = lightObject.GetComponent<Light>();
    }
    public void LightOnOff()
    {
        objectLight.enabled = !objectLight.enabled;
    }

}
