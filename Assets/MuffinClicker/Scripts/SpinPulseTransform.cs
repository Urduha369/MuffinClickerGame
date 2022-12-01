using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPulseTransform : MonoBehaviour
{
    [SerializeField]
    private Transform[] _spinLights;

    [SerializeField]
    private float _spinSpeeds;

    [SerializeField]
    private float _waveSpeed, _waveAmplitude, _waveOffset;

    // Update is called once per frame
    private void Update()
    {
        for (int i = 0; i < _spinLights.Length; i++)
        {
            //Rotate
            Vector3 rotation = new Vector3();
            rotation.z = _spinSpeeds * Time.deltaTime;
            _spinLights[i].Rotate(rotation);

            //Wave
            float wave = Mathf.Sin(Time.time * _waveSpeed) * _waveAmplitude + _waveOffset;
            Vector3 waveScale = new Vector3(wave, wave, wave);
            _spinLights[i].localScale = waveScale;
        }
    }
}
