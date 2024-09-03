using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFireBall : MonoBehaviour
{
    [SerializeField] GameObject fireball;
    [SerializeField] Transform firePoint;
    public float fireRate, bulletSpeed, bulletlife, maxMana, manaPerFireball, manaRegen, currentMana, timeTillNextFire;
    

    // Start is called before the first frame update
    void Start()
    {
        currentMana = maxMana;
    }

    // Update is called once per frame
    void Update()
    {
        //regen mana
        if(currentMana < maxMana)
        {
            currentMana += manaRegen * Time.deltaTime;
            currentMana = Mathf.Min(currentMana, maxMana);
        }

        //auto shoot fireball if enought mana
        if(Time.time >= timeTillNextFire && currentMana >= manaPerFireball)
        {
            Shoot();
            timeTillNextFire = Time.time + fireRate; //time till next fire
        }
    }

    void Shoot()
    {
        currentMana -= manaPerFireball;

        GameObject bullet = Instantiate(fireball,firePoint.position,firePoint.rotation);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = firePoint.up * bulletSpeed;

        Destroy(bullet, bulletlife);
    }

    public float GetCurrentMana()
    {
        return currentMana;
    }

    public float GetMaxMana()
    {
        return maxMana;
    }
}
