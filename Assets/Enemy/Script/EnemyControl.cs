using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour, Dommageable
{
    // Start is called before the first frame update

    private GameObject player;
    private Rigidbody myRigidbody;
    public int movementSpeed = 2;
    
    public void TakeDamage(int damage)
    {
        Die();
    }

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.MovePosition(Vector3.MoveTowards(transform.position, player.transform.position, movementSpeed * Time.deltaTime));
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
