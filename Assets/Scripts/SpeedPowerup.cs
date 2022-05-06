using UnityEngine;

public class SpeedPowerup : MonoBehaviour
{
    public float increase = 10f;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Pickup();
        }

        void Pickup()
        {
            Debug.Log("Power up picked up!");
        }
        
    }
}
