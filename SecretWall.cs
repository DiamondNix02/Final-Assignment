using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWall : MonoBehaviour
{
    public GameObject player;
    public AudioSource SecretAudio;
    bool m_HasAudioPlayed;
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "JohnLemon")
        {
            if (!m_HasAudioPlayed)
            {
                SecretAudio.Play();
                m_HasAudioPlayed = true;
            }
        }
    }
}
