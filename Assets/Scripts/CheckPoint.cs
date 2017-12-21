using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    public int id;
    public List<Sprite> sprites;
    public bool triggered;
    public bool active;

    public AnimationCurve alpha;
        
	void Awake()
    {
        triggered = false;
        SetSprite();
    }
	
    /// <summary>
    /// Every checkpoint object has a trigger.
    /// This trigger activates whenever a "Player" hits the checkpoint, but only if the checkpoint hasn't been triggered yet before...
    /// Once activated, the trigger will be set to true and active will also be set to true.
    /// </summary>
    /// <param name="collider">The object which collides with the checkpoint</param>
    public void OnTriggerEnter2D(Collider2D collider)
    {
        // check we haven't been triggered yet!
        if (!triggered)
        {
            if (collider.gameObject.tag == "Player")
            {
                // Play checkpoint sound
                GetComponents<AudioSource>()[0].Play();
                // Show message about the new checkpoint
                StartCoroutine(ShowMessage("NEW CHECKPOINT", 2.0f));

                // Set checkpoint variables to true
                triggered = true;
                active = true;

                // Notify the checkpoint manager about the collision of this checkpoint so previous ones can be disabled
                Player player = (Player)collider.gameObject.GetComponent("Player");
                player.gamemanager.OnCheckPointTriggered(this);
            }
        }
    }

    /// <summary>
    /// This method sets the sprite of the CheckPoint.
    /// - Not Triggered & Not Active = Blue, you can unlock this checkpoint.
    /// - Triggered & Active = Green, you have unlocked this checkpoint and are currently using it.
    /// - Triggered & Not Active = Red, you have unlocked this checkpoint already but are using another one.
    /// </summary>
    public void SetSprite()
    {
        /*
            // Active = currently in use
            // Triggered = activated

            // !Active = no longer in use
            // !Triggered = not yet activated

            Start value:
            - Triggered: false
            CheckPoint is not yet triggered unless it's the starting point.
            Triggered = true on trigger enter - happens only once

            - Active: false
            CheckPoint is not yet active unless it's the starting point.
            Active = true on trigger enter - happens only once
        */
        if (!triggered)
        {
            // If the checkpoint has not been triggered yet, show the blue sprite
            this.GetComponent<SpriteRenderer>().sprite = sprites[0];
        }
        else if (triggered && active)
        {
            // If the checkpoint has been trigger and is also activated, show the green sprite
            this.GetComponent<SpriteRenderer>().sprite = sprites[1];
        }
        else if (triggered && !active)
        {
            // If the checkpoint has been trigger but no longer is activated, show the red sprite
            this.GetComponent<SpriteRenderer>().sprite = sprites[2];
        }
    }

    public IEnumerator ShowMessage(string msg, float time)
    {
        Transform obj = transform.GetChild(0);

        TextMesh txt = obj.GetComponent<TextMesh>();
        txt.text = msg;

        MeshRenderer renderer = obj.GetComponent<MeshRenderer>();
        renderer.enabled = true;

        float timer = 0.0f;
        while (timer <= time)
        {
            float evalAlpha = 1.0f - alpha.Evaluate(timer / time);
            Color color = txt.color;
            color.a = evalAlpha;
            txt.color = color;
            timer += Time.deltaTime;
            yield return null;
        }
        renderer.enabled = false;
    }
}
