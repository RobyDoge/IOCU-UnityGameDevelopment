
using UnityEngine;

public class DeathCounter : MonoBehaviour
{
    [SerializeField]
    private DeathLoader _deathLoader;

    private void Start()
    {
        _deathLoader.Load();
    }
}
