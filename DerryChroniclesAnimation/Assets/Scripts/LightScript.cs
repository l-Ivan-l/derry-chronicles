using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{

    float duration  = 3.0f;
    float originalRange;
    private float lightIntensity;
    private float minInt = 8f;
    private float maxInt = 11f;

    private Light fireLight;
    // Start is called before the first frame update
    void Start()
    {
      fireLight = GetComponent<Light>();
      originalRange = fireLight.range;
    }

    // Update is called once per frame
    void Update()
    {
      var amplitude = Mathf.PingPong(Time.time, duration);

      // Transform from 0..duration to 0.5..1 range.
      amplitude = amplitude / duration * 0.5f + 0.9f;

      // Set light range.
      fireLight.range = originalRange * amplitude;
    }

    void LateUpdate()
    {
      lightIntensity = Random.Range(minInt, maxInt);
      fireLight.intensity = lightIntensity;
    }

}//class
