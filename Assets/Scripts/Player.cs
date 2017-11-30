using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isGrounded = false;
    public LayerMask playerMask;
    public float walkSpeed;
    public float jumpHeight;
    public bool dead;
    public bool invulnerable;
    private float invulnerableTime;
    public Direction moveDirection;
    public PlayerType type;
    public GameManager gamemanager;
    private bool jumped;


	public enum PlayerType { Normal, Upgraded }
    public enum Direction { Left, Right }

    private void Start()
    {
		try
		{
			gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
		}
		catch
		{
			gamemanager = null;
		}
        
	}

    void FixedUpdate()
    {
        invulnerableTime -= Time.deltaTime;
        if (invulnerableTime < 0)
        {
            invulnerable = false;
        }

        if (type == PlayerType.Normal)
        {
            this.GetComponent<CapsuleCollider2D>().size = new Vector2(0.5f, 0.6f);
            this.GetComponent<CapsuleCollider2D>().offset = new Vector2(0, 0);
            isGrounded = Physics2D.Linecast(this.transform.position, new Vector2(this.transform.position.x, this.transform.position.y - 0.35f), playerMask);
        }
        else if (type == PlayerType.Upgraded)
        {
            this.GetComponent<CapsuleCollider2D>().size = new Vector2(0.5f, 1.1f);
            this.GetComponent<CapsuleCollider2D>().offset = new Vector2(0, -0.08f);
            isGrounded = Physics2D.Linecast(this.transform.position, new Vector2(this.transform.position.x, this.transform.position.y - 0.70f), playerMask);
        }
        

        if (this.dead == false)
        {
			if (gamemanager != null)
			{
				if (Input.GetKey("left") || gamemanager.left == true)
				{
					this.moveDirection = Direction.Left;
					this.transform.Translate(new Vector2(-walkSpeed / 10, 0));
				}
				if (Input.GetKey("right") || gamemanager.right == true)
				{
					this.moveDirection = Direction.Right;
					this.transform.Translate(new Vector2(walkSpeed / 10, 0));
				}
				if (Input.GetKey("up") || gamemanager.jump == true)
				{
					if (isGrounded == true && jumped == false)
					{
						Jump();
						jumped = true;
					}

				}
			}
			else
			{
				if (Input.GetKey("left"))
				{
					this.moveDirection = Direction.Left;
					this.transform.Translate(new Vector2(-walkSpeed / 10, 0));
				}
				if (Input.GetKey("right"))
				{
					this.moveDirection = Direction.Right;
					this.transform.Translate(new Vector2(walkSpeed / 10, 0));
				}
				if (Input.GetKey("up"))
				{
					if (isGrounded == true && jumped == false)
					{
						Jump();
						jumped = true;
					}

				}
			}
			if (gamemanager != null)
			{

				if (Input.GetKey("up") == false && gamemanager.jump == false)
				{
					jumped = false;
				}
			}
			else
			{
				if (Input.GetKey("up") == false)
				{
					jumped = false;
				}
			}

        }
        else if (dead == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            this.GetComponent<Rigidbody2D>().isKinematic = true;
            this.GetComponent<CapsuleCollider2D>().enabled = false;
        }

        ChangeSprite();
    }

    public void Jump()
    {
        this.GetComponents<AudioSource>()[3].Play();
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
    }

	void ChangeSprite()
	{
		if (dead == true)
		{
			this.GetComponent<SpriteRenderer>().flipY = true;
		}
		if (invulnerable == true)
		{
			this.GetComponent<SpriteRenderer>().color = Color.grey;
		}
		else
		{
			this.GetComponent<SpriteRenderer>().color = Color.white;
		}
		if (isGrounded == true)
		{
			this.GetComponent<Animator>().SetBool("grounded", true);
		}
		else
		{
			this.GetComponent<Animator>().SetBool("grounded", false);
		}
		if (this.moveDirection == Direction.Left)
		{
			this.GetComponent<SpriteRenderer>().flipX = false;
		}
		else if (this.moveDirection == Direction.Right)
		{
			this.GetComponent<SpriteRenderer>().flipX = true;
		}
		this.GetComponent<Animator>().SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));
	}

    public void Hit()
    {
        if (invulnerable == false)
        {
            if (type == Player.PlayerType.Normal)
            {
                this.GetComponents<AudioSource>()[2].Play();
                dead = true;
            }
            else if (type == Player.PlayerType.Upgraded)
            {
                this.GetComponents<AudioSource>()[0].Play();
                type = Player.PlayerType.Normal;
                invulnerable = true;
                invulnerableTime = 1;
            }
        }
    }
    public void Powerup(PlayerType powerupType)
    {
        if (powerupType == PlayerType.Upgraded)
        {
            this.GetComponents<AudioSource>()[1].Play();
            type = PlayerType.Upgraded;
        }
    }
}
