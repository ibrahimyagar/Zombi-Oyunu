using UnityEngine;
using System.Collections;
public class Health1 : MonoBehaviour {
[SerializeField] int _maximumHealth = 100;
[SerializeField] int _currentHealth = 0;
void Start()
    {
        _currentHealth = _maximumHealth; 
    }

 public void Damage(int damageValue) 
    {
        _currentHealth -= damageValue;
        if (_currentHealth <= 0)
        {     
            Destroy(gameObject);
        }
    }
}