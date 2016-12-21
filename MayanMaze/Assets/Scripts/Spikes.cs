using UnityEngine;
using System.Collections;

public class Spikes : Traps {
    //  All current functions derived from Traps.cs
    //  Further customization of the spike trap will come later

    public enum Status { UP, DOWN };
    public Status spikeStatus;

    void OnCollisionEnter2D(Collision2D otherCollider)
    {
        if(spikeStatus == Status.UP)
        {
            Debug.Log("Ouch");

            //  Call the base class to perform root-level operations
            base.OnCollisionEnter2D(otherCollider);
        }
        else if(spikeStatus == Status.DOWN)
        {
            Debug.Log("HOLES!");
        }
    }

    public void SetStatus(Status toStatus)
    {
        spikeStatus = toStatus;
    }
}
