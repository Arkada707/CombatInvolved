using UnityEngine;

public class DamageIncPowerup : MonoBehaviour
{
    public float increase= 70f;
    private float health;
    [SerializeField] private float maxHealth = 1f;
    [SerializeField]
    private float attackDamage = 10f;

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject bullet = collision.gameObject;
            Bullet bulletScript = bullet.GetComponent<Bullet>();

            if (bulletScript)
            {
                float c = bulletScript.bulletDamage + attackDamage;
                c += increase;
                Destroy(gameObject);
            }
        }
        
    }
}

