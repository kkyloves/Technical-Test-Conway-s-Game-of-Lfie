using TMPro;
using UnityEngine;

public class GenerationCounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_generationCounterText;

    public void UpdateGenerationCounterText(int p_generationCount)
    {
        m_generationCounterText.text = p_generationCount.ToString();
    }
}
