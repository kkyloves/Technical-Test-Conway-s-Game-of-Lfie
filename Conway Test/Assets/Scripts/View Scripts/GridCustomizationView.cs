using TMPro;
using UnityEngine;

namespace View_Scripts
{
    public class GridCustomizationView : MonoBehaviour
    {
        [SerializeField] private TMP_InputField m_rowInputField;
        [SerializeField] private TMP_InputField m_columnInputField;
        [SerializeField] private TMP_InputField m_speedInputField;

        private void Awake()
        {
            m_rowInputField.onEndEdit.AddListener(text =>
            {
                GameManger.Instance.CellGridController.SetGridRowCount(int.Parse(text));
            });
            
            m_columnInputField.onEndEdit.AddListener(text =>
            {
                GameManger.Instance.CellGridController.SetGridColumnCount(int.Parse(text));
            });
            
            m_speedInputField.onEndEdit.AddListener(text =>
            {
                GameManger.Instance.GenerationController.GenerationSpeed = int.Parse(text);
            });
        }
    }
}
