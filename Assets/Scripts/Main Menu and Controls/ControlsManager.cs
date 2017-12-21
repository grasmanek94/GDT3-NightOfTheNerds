using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlsManager : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    private List<GameObject> bullets;

    private bool jump = false;
    private bool down = false;
    private int maxBullets = 10;
	void Start()
    {
        bullets = new List<GameObject>();
        for (int i = 0; i < maxBullets; i++)
        {
            GameObject newBullet = Instantiate(bullet);
            newBullet.SetActive(false);
            bullets.Add(newBullet);
        }
        Input.multiTouchEnabled = true;
	}
	
	void Update()
    {
        if (Input.GetKeyDown("space") && !jump && !down)
        {
            jump = true;
        }

        if (jump)
        {
             if (player.transform.position.y < 3.2)
             {
                 player.transform.Translate(Vector3.up * Time.deltaTime * 5);
             }

             else if (player.transform.position.y > 3)
             {
                 down = true;
                 jump = false;
             }
        }

        if (down && !jump)
        {
            if (player.transform.position.y > 0)
            {
                 Debug.Log("down");
                 player.transform.Translate(Vector3.down * Time.deltaTime * 5);
            }

            else
            {
                 down = false;
            }
        }
    }

    public void Shoot()
    {
        GameObject bullet = findInActiveBullet();
        if (bullet)
        {
            bullet.transform.position = player.transform.position;
            bullet.SetActive(true);        
        }

        else
        {
            Debug.Log("can't spawn");
        }
    }

    private GameObject findInActiveBullet()
    {
        foreach (GameObject bullet in bullets)
        {
            if (!bullet.activeInHierarchy)
            {
                return bullet;
            }
        }

        return null;
    }

    public void OnSubmit(string action)
    {     
        Debug.Log("submit");
        if (action == "jump" && !jump && !down)
        {
            jump = true;
        }

        else if(action == "shoot")
        {
            Shoot();
        }
    }
}
