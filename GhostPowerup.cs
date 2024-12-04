using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPowerup : MonoBehaviour
{
    public AudioSource PowerupAudio;
    bool m_HasAudioPlayed;
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "JohnLemon")
        {
            if (!m_HasAudioPlayed)
            {
                PowerupAudio.Play();
                m_HasAudioPlayed = true;
            }
            Destroy(gameObject);
        }
    }
}
