using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBlock : MonoBehaviour {

    public Sprite spriteFull;
    public Sprite spriteEmpty;
    public LootBlockState state;

    public enum LootBlockState { Empty, Mushroom, Goomba }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.GetComponent<SpriteRenderer>().sprite = spriteEmpty;

            if (state == LootBlockState.Mushroom)
            {
                this.GetComponents<AudioSource>()[0].Play();
                state = LootBlockState.Empty;
                Instantiate(Resources.Load("Prefabs/Mushroom"), new Vector2(this.transform.position.x, this.transform.position.y + 0.64f), Quaternion.identity);
            }
            else if (state == LootBlockState.Goomba)
            {
                this.GetComponents<AudioSource>()[0].Play();
                state = LootBlockState.Empty;
                Instantiate(Resources.Load("Prefabs/Goomba"), new Vector2(this.transform.position.x, this.transform.position.y + 0.64f), Quaternion.identity);
            }
        }
    }
}
