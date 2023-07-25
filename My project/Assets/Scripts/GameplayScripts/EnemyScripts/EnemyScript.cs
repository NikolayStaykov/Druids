using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using UnityEngine;

public abstract class AbstractEnemy : MonoBehaviour
{
    private int _maxHealth;
    private int _currentHealth;
    private int _movementSpeed;
    private int _attackPower;
    private double _attackSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool takeDamage(int Damage)
    {
        _currentHealth -= Damage;
        if(_currentHealth < 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        return false;
    }


}
