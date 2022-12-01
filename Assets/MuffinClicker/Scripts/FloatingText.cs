using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// 1. Floats the text upwards
/// 2. Fades the text
/// 3. Destroys the text
/// </summary>


public class FloatingText : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _text;

    [SerializeField]
    private float _moveSpeed;

    private float _timer;
    private Color _startColor;

    // Start is called before the first frame update
    void Start()
    {
        if (_text != null)
            _startColor = _text.color;
    }

    // Update is called once per frame
    void Update()
    {
        // We want movement speed to move with time and not with framerate
        transform.Translate(0, _moveSpeed * Time.deltaTime, 0);

        _timer = _timer + Time.deltaTime;

        if (_text != null)
        {
            _text.color = Color.Lerp(_startColor, Color.clear, _timer);
        }
        
        if (_timer >= 60)
        {
            Destroy(gameObject);
        }
    }
}
