using UnityEngine;

public class RecoverDamage : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Health>().Healing(10);
    }

    public void OnTriggerStay(Collider other)
    {
        other.gameObject.GetComponent<Health>().Healing(0.5f);
    }
}
