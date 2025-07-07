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
        Destroy(gameObject);
        // Also, it can be fixed by replacing an empty array after triggering on it.
        // projectiles = Array.Empty<GameObject>();
    }
}