using UnityEngine;
using System.Collections;

public class Spikes : Traps {
    //  All current functions derived from Traps.cs
    //  Further customization of the spike trap will come later

    public enum Status { UP, DOWN };
    public Status spikeStatus;

    public bool fixedState;

    public Sprite[] spikeStateSprites;

    void Start()
    {
        base.Start();
        Animator myAnimator = GetComponent<Animator>();

        SetSpikeStatus(myAnimator);
    }

    //  This function sets the basic UP and DOWN state for spikes at start
    private void SetSpikeStatus(Animator myAnimator)
    {
        SpriteRenderer mySpriteRenderer = GetComponent<SpriteRenderer>();
        Collider2D myCollider = GetComponent<Collider2D>();

        //  Turn off the animation it the spikes are in a fixed state
        if (fixedState)
            myAnimator.enabled = false;

        //  Set the correct image for the spikes
        switch (spikeStatus)
        {
            case Status.UP:
                {
                    mySpriteRenderer.sprite = spikeStateSprites[0];
                    break;
                }
            case Status.DOWN:
                {
                    mySpriteRenderer.sprite = spikeStateSprites[1];
                    myCollider.enabled = false;
                    break;
                }
        }
    }

    //  This is the public version of the function for use by switches and animations
    //  If new statuses are created in the future, the function may need to be renamed for accuracy.
    public void SetSpikeStatus()
    {
        SpriteRenderer mySpriteRenderer = GetComponent<SpriteRenderer>();
        Collider2D myCollider = GetComponent<Collider2D>();

        //  Alter settings for the spikes
        switch (spikeStatus)
        {
            case Status.UP:
                {
                    spikeStatus = Status.DOWN;
                    mySpriteRenderer.sprite = spikeStateSprites[1];
                    myCollider.enabled = false;
                    break;
                }
            case Status.DOWN:
                {
                    spikeStatus = Status.UP;
                    mySpriteRenderer.sprite = spikeStateSprites[0];
                    myCollider.enabled = true;
                    break;
                }
        }
    }

    void OnCollisionEnter2D(Collision2D otherCollider)
    {
        if(spikeStatus == Status.UP)
        {
            Debug.Log("Ouch");

            //  Call the base class to perform root-level operations
            base.OnCollisionEnter2D(otherCollider);
        }
    }

    public void SetStatus(Status toStatus)
    {
        spikeStatus = toStatus;
    }
}
