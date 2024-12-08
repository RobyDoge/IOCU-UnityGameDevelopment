using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] private float _MovementSpeed;
    private EnemyCharacter _enemyCharacter;
    private bool _canDealDamage = true;
    
    void Start()
    {
        
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * _MovementSpeed);

        if (Input.GetKeyDown(KeyCode.Space) && _canDealDamage)
        {
            _enemyCharacter.TakeDamage();
            _canDealDamage = false;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _canDealDamage = true; 
        }

    }
    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            _enemyCharacter = collision.gameObject.GetComponent<EnemyCharacter>();
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            _enemyCharacter = null;
        }
    }
}
