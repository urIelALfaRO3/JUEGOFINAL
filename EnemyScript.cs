using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public GameObject Player;
    private float LastShoot;
    private int Vida = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Player == null) return;
        
        Vector3 direction = Player.transform.position - transform.position;
        if(direction.x >= 0.0f)transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        else transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

        float distance = Mathf.Abs(Player.transform.position.x - transform.position.x);

        if(distance < 1.0f && Time.time > LastShoot + 0.25f)
        {
            Shoot();
            LastShoot = Time.time;
        }

    }

    private void Shoot()
    {
        Vector3 direction;
        if (transform.localScale.x == 1.0f) direction = Vector3.right;
        else direction = Vector3.left;

        GameObject Bullet = Instantiate(BulletPrefab,transform.position + direction * 0.1f, Quaternion.identity);
        Bullet.GetComponent<BalaScript>().SetDirection(direction); 
    }

    public void Hit()
    {
        Vida = Vida - 1;
        if(Vida == 0) Destroy(gameObject);
    }

    
    

}
