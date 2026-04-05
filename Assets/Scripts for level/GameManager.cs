using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int totalSpheresOnLevel = 3;
    private int collectedSpheres = 0;

    public TextMeshProUGUI sphereText;

    void Awake()
    {
        if (Instance == null) Instance = this;
    }

    void Start()
    {
        UpdateUI();
    }

    public void AddSphere()
    {
        collectedSpheres++;
        UpdateUI();
    }

    public bool AreAllSpheresCollected()
    {
        return collectedSpheres >= totalSpheresOnLevel;
    }

    private void UpdateUI()
    {
        if (sphereText != null)
        {
            sphereText.text = $"—фер з≥брано: {collectedSpheres}/{totalSpheresOnLevel}";
        }
    }
}