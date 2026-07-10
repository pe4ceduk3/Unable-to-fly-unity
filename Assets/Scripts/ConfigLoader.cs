using System.IO;
using Components.Data;
using UnityEngine;


public class ConfigLoader : MonoBehaviour
{
    private readonly string _movementPath = "Player/JumpData/BallisticsData.json";
    void Start()
    {
        BallisticsData movementData = Create<BallisticsData>(_movementPath);
        Debug.Log($"{movementData.Peak}, {movementData.Duration} ");
    }
    public static T Create<T>(string filePath)
    {
        string path = Path.Combine(Application.streamingAssetsPath, filePath);
        if (!File.Exists(path))
        {
            Debug.LogError($"File not found: {path}");
            return default;
        }
        string json = File.ReadAllText(path);
        return JsonUtility.FromJson<T>(json);
    }
}
