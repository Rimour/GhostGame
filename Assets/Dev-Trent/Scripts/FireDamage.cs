using UnityEngine;

public class FireDamage : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Health>().TakeDamage(10);
    }

    public void OnTriggerStay(Collider other)
    {
        other.gameObject.GetComponent<Health>().TakeDamage(0.5f);
    }
}
