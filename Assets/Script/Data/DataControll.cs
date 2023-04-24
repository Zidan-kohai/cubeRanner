using TMPro;
using UnityEngine;

public class DataControll : MonoBehaviour
{
    [Header("TMP")]
    [SerializeField] private TMP_InputField VelocityTMP;
    [SerializeField] private TMP_InputField DistanceTMP;
    [SerializeField] private TMP_InputField TimeToNextSpawnTMP;

    [SerializeField] public static float Velocity;
    [SerializeField] public static float Distance;
    [SerializeField] public static float TimeToNextSpawn;

    [Header("UI")]
    [SerializeField] private TextMeshProUGUI _velocityWarning;
    void Start()
    {
        VelocityTMP.onValueChanged.AddListener(OnVelocityChanged);
        DistanceTMP.onValueChanged.AddListener(OnDistanceChanged);
        TimeToNextSpawnTMP.onValueChanged.AddListener(OnTimeToNextSpawnChanged);
    }

    private void OnVelocityChanged(string str)
    {
        if(!float.TryParse(str, out Velocity)){
            Velocity = 0;
            _velocityWarning.enabled = true;
            return;
        }
        _velocityWarning.enabled = false;
    }
    private void OnDistanceChanged(string str)
    {
        if (!float.TryParse(str, out Distance))
        {
            Distance = 0;
        }
    }
    private void OnTimeToNextSpawnChanged(string str)
    {
        if (!float.TryParse(str, out TimeToNextSpawn))
        {
            TimeToNextSpawn = 0;
        }
    }
    private void OnDestroy()
    {
        VelocityTMP.onValueChanged.RemoveListener(OnVelocityChanged);
        DistanceTMP.onValueChanged.RemoveListener(OnDistanceChanged);
        TimeToNextSpawnTMP.onValueChanged.RemoveListener(OnTimeToNextSpawnChanged);
    }
}
