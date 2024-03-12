using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoController : MonoBehaviour
{
    AudioSource _Do, _Re, _Mi, _Pha, _Son, _La, _Si;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        _Do = GameObject.FindWithTag("Do").GetComponent<AudioSource>();
        _Re = GameObject.FindWithTag("Re").GetComponent<AudioSource>();
        _Mi = GameObject.FindWithTag("Mi").GetComponent<AudioSource>();
        _Pha = GameObject.FindWithTag("Pha").GetComponent<AudioSource>();
        _Son = GameObject.FindWithTag("Son").GetComponent<AudioSource>();
        _La = GameObject.FindWithTag("La").GetComponent<AudioSource>();
        _Si = GameObject.FindWithTag("Si").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Debug.Log("Do");
            _Do.Play();

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("Re");
            _Re.Play();
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Debug.Log("Mi");
            _Mi.Play();
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            Debug.Log("Pha");
            _Pha.Play();
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
            Debug.Log("Son");
            _Son.Play();
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            Debug.Log("La");
            _La.Play();
        }
        if (Input.GetKeyUp(KeyCode.U))
        {
            Debug.Log("Si");
            _Si.Play();
        }
    }
}
