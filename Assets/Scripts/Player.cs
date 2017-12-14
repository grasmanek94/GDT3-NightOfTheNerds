using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
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
	private bool fired;
    private Vector3 lastPosition;
    private float speed;
	public float bulletSpeed;
	public BulletType bulletType;

	public enum BulletType { SingleLaser, DualLaser, TrippleLaser };
	public enum PlayerType { Normal, Upgraded, Shooter };
	public enum Direction { Left, Right };

    private GameObject upgradeParticles;
    private int lasers = 0;

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
        Debug.Log(lasers);
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
			this.GetComponent<CapsuleCollider2D>().size = new Vector2(0.5f, 0.6f);
			this.GetComponent<CapsuleCollider2D>().offset = new Vector2(0, 0);
			isGrounded = Physics2D.Linecast(this.transform.position, new Vector2(this.transform.position.x, this.transform.position.y - 0.35f), playerMask);
            /*this.GetComponent<CapsuleCollider2D>().size = new Vector2(0.5f, 1.1f);
            this.GetComponent<CapsuleCollider2D>().offset = new Vector2(0, -0.08f);
            isGrounded = Physics2D.Linecast(this.transform.position, new Vector2(this.transform.position.x, this.transform.position.y - 0.70f), playerMask);*/
        }
		else if (type == PlayerType.Shooter)
		{
			this.GetComponent<CapsuleCollider2D>().size = new Vector2(0.5f, 0.6f);
			this.GetComponent<CapsuleCollider2D>().offset = new Vector2(0, 0);
			isGrounded = Physics2D.Linecast(this.transform.position, new Vector2(this.transform.position.x, this.transform.position.y - 0.35f), playerMask);
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
				if (Input.GetKey(KeyCode.LeftControl) || gamemanager.shoot == true)
				{
					if (type == PlayerType.Shooter && fired == false)
					{
						Shoot ();
						fired = true;
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
				if (Input.GetKey(KeyCode.LeftControl))
				{
					if (type == PlayerType.Shooter && fired == false)
					{
						Shoot ();
						fired = true;
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
			if (gamemanager != null)
			{

				if (Input.GetKey(KeyCode.LeftControl) == false && gamemanager.shoot == false)
				{
					fired = false;
				}
			}
			else
			{
				if (Input.GetKey(KeyCode.LeftControl) == false)
				{
					fired = false;
				}
			}

        }
        else if (dead == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            this.GetComponent<Rigidbody2D>().isKinematic = true;
            this.GetComponent<CapsuleCollider2D>().enabled = false;
        }

        speed = (transform.position.x - lastPosition.x);
        lastPosition = transform.position;

        ChangeSprite();

    }

    public void Jump()
    {
        this.GetComponents<AudioSource>()[3].Play();
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
    }

	public void Shoot()
	{
        if (lasers < 4)
        {
            this.GetComponents<AudioSource>()[4].Play();
            if (bulletType == BulletType.SingleLaser)
            {
                GameObject laser = (GameObject)Instantiate(Resources.Load("Prefabs/Laser"), new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                laser.GetComponent<Laser>().SetPlayer(this);
                lasers++;
                Destroy(laser, 1);
                if (moveDirection == Direction.Left)
                {
                    laser.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed * -1, 0), ForceMode2D.Impulse);
                }
                else if (moveDirection == Direction.Right)
                {
                    laser.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed, 0), ForceMode2D.Impulse);
                }
            }
            else if (bulletType == BulletType.DualLaser)
            {
                GameObject laserStraight = (GameObject)Instantiate(Resources.Load("Prefabs/Laser"), new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                laserStraight.GetComponent<Laser>().SetPlayer(this);
                lasers++;
                GameObject laserUp = (GameObject)Instantiate(Resources.Load("Prefabs/Laser"), new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                laserUp.GetComponent<Laser>().SetPlayer(this);
                lasers++;
                Destroy(laserStraight, 1);
                Destroy(laserUp, 1);
                if (moveDirection == Direction.Left)
                {
                    laserStraight.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed * -1, 0), ForceMode2D.Impulse);
                    laserUp.transform.rotation = new Quaternion(0, 0, -35, 180);
                    laserUp.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed * -1, 2), ForceMode2D.Impulse);
                }
                else if (moveDirection == Direction.Right)
                {
                    laserStraight.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed, 0), ForceMode2D.Impulse);
                    laserUp.transform.rotation = new Quaternion(0, 0, 35, 180);
                    laserUp.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed, 2), ForceMode2D.Impulse);
                }
            }
            else if (bulletType == BulletType.TrippleLaser)
            {
                GameObject laserStraight = (GameObject)Instantiate(Resources.Load("Prefabs/Laser"), new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                laserStraight.GetComponent<Laser>().SetPlayer(this);
                lasers++;
                GameObject laserDown = (GameObject)Instantiate(Resources.Load("Prefabs/Laser"), new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                laserDown.GetComponent<Laser>().SetPlayer(this);
                lasers++;
                GameObject laserUp = (GameObject)Instantiate(Resources.Load("Prefabs/Laser"), new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                laserUp.GetComponent<Laser>().SetPlayer(this);
                lasers++;
                Destroy(laserStraight, 1);
                Destroy(laserDown, 1);
                Destroy(laserUp, 1);
                if (moveDirection == Direction.Left)
                {
                    laserStraight.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed * -1, 0), ForceMode2D.Impulse);
                    laserDown.transform.rotation = new Quaternion(0, 0, 35, 180);
                    laserDown.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed * -1, -2), ForceMode2D.Impulse);
                    laserUp.transform.rotation = new Quaternion(0, 0, -35, 180);
                    laserUp.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed * -1, 2), ForceMode2D.Impulse);
                }
                else if (moveDirection == Direction.Right)
                {
                    laserStraight.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed, 0), ForceMode2D.Impulse);
                    laserDown.transform.rotation = new Quaternion(0, 0, -35, 180);
                    laserDown.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed, -2), ForceMode2D.Impulse);
                    laserUp.transform.rotation = new Quaternion(0, 0, 35, 180);
                    laserUp.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed, 2), ForceMode2D.Impulse);
                }
            }
        }
	}

    public void RemoveLaser()
    {
        lasers--;
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
        if (Mathf.Abs(speed) > 0)
        {
            this.GetComponent<Animator>().SetFloat("speed", 1);
        }
        else
        {
            this.GetComponent<Animator>().SetFloat("speed", 0);
        }
        if (type == PlayerType.Upgraded)
        {
            Color c = new Color32(255, 144, 144, 255);
            this.GetComponent<SpriteRenderer>().color = c;
        }
        else if (type == PlayerType.Shooter)
        {
            Color c = new Color32(144, 255, 144, 255);
            this.GetComponent<SpriteRenderer>().color = c;
        }
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
                Destroy(upgradeParticles);
                invulnerable = true;
                invulnerableTime = 1;
            }
			else if (type == Player.PlayerType.Shooter)
			{
				this.GetComponents<AudioSource>()[2].Play();
				dead = true;
			}
        }
    }
    public void Powerup(PlayerType powerupType)
    {
        if (powerupType == PlayerType.Upgraded)
        {
            this.GetComponents<AudioSource>()[1].Play();
            type = PlayerType.Upgraded;
            upgradeParticles = (GameObject)Instantiate(Resources.Load("Prefabs/PowerupParticles"));
            upgradeParticles.transform.SetParent(this.transform);
            upgradeParticles.transform.localPosition = Vector3.zero;
        }
		else if (powerupType == PlayerType.Shooter)
		{
            this.GetComponents<AudioSource>()[1].Play();
			type = PlayerType.Shooter;
            Destroy(upgradeParticles);
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "MovingPlatform")
        {
            Debug.Log("Entered Moving Platform");
            transform.SetParent(col.gameObject.transform);
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "MovingPlatform")
        {
            Debug.Log("Leaving");
            transform.SetParent(null);
        }
    }
}
