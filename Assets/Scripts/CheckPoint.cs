using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    public int id;
    public List<Sprite> sprites;
    public bool active;

    public AnimationCurve alpha;

    void Awake()
    {
        active = false;
        SetSprite();
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (!active)
        {
            if (collider.gameObject.tag == "Player")
            {
                // Play checkpoint sound
                GetComponents<AudioSource>()[0].Play();
                // Show message about the new checkpoint
                StartCoroutine(ShowMessage("NEW CHECKPOINT", 1.0f));

                // Set checkpoint variables to true
                active = true;

                // Notify the checkpoint manager about the collision of this checkpoint so previous ones can be disabled
                Player player = (Player)collider.gameObject.GetComponent("Player");
                player.gamemanager.OnCheckPointTriggered(this);
                SetSprite();
            }
        }
    }

    /// <summary>
    /// This method sets the sprite for the checkpoint based on whether it's active or not.
    /// </summary>
    public void SetSprite()
    {
        if (active)
        {
            this.GetComponent<SpriteRenderer>().sprite = sprites[1];
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = sprites[0];
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
