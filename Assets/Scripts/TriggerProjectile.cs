using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectiles;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ActivateProjectiles();
        }
    }

    private void ActivateProjectiles()
    {
        foreach (GameObject projectile in projectiles)
        {
            projectile.SetActive(true);
        }
    }
}