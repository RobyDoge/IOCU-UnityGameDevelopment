using TMPro;
using UnityEngine;

public class EnemyCharacter : MonoBehaviour
{
    [SerializeField] private int _Health;
    public TextMeshPro healthText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateHealthText();
    }

    // Update is called once per frame
    void Update()
    {
        //healthText.transform.LookAt(Camera.main.transform);
    }
    private void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = _Health.ToString();
            healthText.color = Color.red;
        }
    }

    public void TakeDamage()
    {
        if (_Health > 0)
        {
            _Health--;
            UpdateHealthText();
        }
        if(_Health == 0)
        {
            Destroy(gameObject);
        }

    }
}
