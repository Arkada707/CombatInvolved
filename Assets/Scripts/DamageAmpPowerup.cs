using UnityEngine;

public class DamageAmpPowerup : MonoBehaviour
{
    public float increase= 70f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject bullet = collision.gameObject;
            Bullet bulletScript = bullet.GetComponent<Bullet>();

            if (bulletScript)
            {
                Debug.Log("Damage increased");
                bulletScript.bulletDamage += increase;
                Destroy(gameObject);
            }
        }
        
    }
}

