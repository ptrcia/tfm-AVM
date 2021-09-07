using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class LightButton : MonoBehaviour
{
    [SerializeField] private float theshold = 0.1f;
    [SerializeField] private float deadzone = 0.025f;
    public AudioSource Sonido;
    private bool on;
    public Light luz;

    private bool _isPressed;
    private Vector3 _startPos;
    private ConfigurableJoint _joint;

    public UnityEvent onPressed, onReseased;
    void Start()
    {
        _startPos = transform.localPosition;
        _joint = GetComponent<ConfigurableJoint>();
        Sonido = GetComponent<AudioSource>();
        //luz = GetComponent<Light>();
        on = false;
        _isPressed = false;
        //Debug.Log(luz);
    }

    void Update()
    {
        if (!_isPressed && GetValue() + theshold >= 1)
            Pressed();
        if (_isPressed && GetValue() - theshold <= 0)
            Reseased();
    }
    private float GetValue()
    {
        var value = Vector3.Distance(_startPos, transform.localPosition) / _joint.linearLimit.limit;
        if (Math.Abs(value) < deadzone)
            value = 0;
        return Mathf.Clamp(value, -1f, 1f);
    }
    private void Pressed()
    {
        _isPressed = true;
        onPressed.Invoke();
        Sonido.Play(); //sonido al pulsar

        if (on == false) 
        {
            luz.gameObject.SetActive(true);

            on = true;
        }
        else
        {
            luz.gameObject.SetActive(false);

            on = false;
        }
    }
    private void Reseased()
    {
        _isPressed = false;
        onReseased.Invoke();
        //Debug.Log("Released");
    }
}
