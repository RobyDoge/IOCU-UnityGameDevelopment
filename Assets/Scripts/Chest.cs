using UnityEngine;

public class Chest : MonoBehaviour
{
    private Animator _animator;
    private ParticleSystem _particleSystem;
    private AudioSource _audioSource;

    [SerializeField] private AudioClip _openChestSound;
    [SerializeField] private AudioClip _GoldSound;
    
    void Start()
    {
        _animator = GetComponent<Animator>();
        _particleSystem = GetComponentInChildren<ParticleSystem>();
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenChest()
    {
        _animator.Play("ChestOpening");
    }

    public void PlayOpenChestSound()
    {
        _audioSource.clip = _openChestSound;
        _audioSource.Play();
    }

    public void TriggerCoinParticles()
    {
        _particleSystem.Play();

        _audioSource.clip = _GoldSound;
        _audioSource.Play();
    }
}
