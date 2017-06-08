using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

    public Spikes[] targetSpikes;

    void OnTriggerEnter2D(Collider2D collider)
    {
        foreach(Spikes spike in targetSpikes)
        {
            spike.SetSpikeStatus();
        }
    }
}
