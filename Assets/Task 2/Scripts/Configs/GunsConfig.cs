using UnityEngine;

[CreateAssetMenu(fileName = "GunsConfig", menuName = "Configs/GunsConfig")]
public class GunsConfig : ScriptableObject
{
    [SerializeField] private PistolConfig _pistolConfig;
    [SerializeField] private RifleConfig _rifleConfig;
    [SerializeField] private ShotgunConfig _shotgunConfig;

    public PistolConfig PistolConfig => _pistolConfig;
    public RifleConfig RifleConfig => _rifleConfig;
    public ShotgunConfig ShotgunConfig => _shotgunConfig;
}
