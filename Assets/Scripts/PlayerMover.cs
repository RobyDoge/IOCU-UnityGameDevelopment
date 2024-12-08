using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _MovementSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * _MovementSpeed);

        if (Input.GetKey(KeyCode.E))
            transform.Translate(Vector3.up * _MovementSpeed);
        if (Input.GetKey(KeyCode.Q))
            transform.Translate(Vector3.down * _MovementSpeed);
    }
}
