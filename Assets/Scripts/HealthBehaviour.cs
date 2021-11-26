using UnityEngine;
using UnityEngine.Events;

public class HealthBehaviour : MonoBehaviour
{
    public int maxHealth, startHealth;

    public int currentHealth { get; private set; }

    public UnityEvent<int> healthModified;

    public UnityEvent damageTaken;

    private void Start()
    {
        currentHealth = startHealth;
        healthModified.Invoke(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        ModifyHealth(-damage);
        damageTaken.Invoke();
    }

    public void Heal(int health)
    {
        ModifyHealth(health);
    }

    private void ModifyHealth(int modifier)
    {
        currentHealth = Mathf.Clamp(currentHealth + modifier, 0, maxHealth);
        healthModified.Invoke(currentHealth);
    }
}
