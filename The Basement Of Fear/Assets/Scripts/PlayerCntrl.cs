using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCntrl : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;   // Player movement speed

    private Rigidbody rb;       // Rigidbody
    private AudioSource audio;  // Audio

    void Start()
    {
        // Pull Components
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();

        // Cursor settings
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        bool isMoved = false; // Player move?

        // MOVEMENT
        if (Input.GetKey(KeyCode.W))
        {
            rb.MovePosition(rb.position + transform.forward * speed * Time.fixedDeltaTime);
            isMoved = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(rb.position - transform.right * speed * Time.fixedDeltaTime);
            isMoved = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.MovePosition(rb.position - transform.forward * speed * Time.fixedDeltaTime);
            isMoved = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(rb.position + transform.right * speed * Time.fixedDeltaTime);
            isMoved = true;
        }

        // AUDIO
        if (isMoved && !audio.isPlaying)
        {
            audio.Play();
        }
        else if (!isMoved && audio.isPlaying)
        {
            audio.Stop();
        }
    }
}
