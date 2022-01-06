using TMPro;
using UnityEngine;

public class CurrentDataSectionView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_currentGenerationCountText;
    [SerializeField] private TextMeshProUGUI m_currentLivingCellCountText;

    public void UpdateGenerationCountText(int p_count)
    {
        m_currentGenerationCountText.text = p_count.ToString();
    }

    public void UpdateLivingCountText(int p_count)
    {
        m_currentLivingCellCountText.text = p_count.ToString();
    }
}
