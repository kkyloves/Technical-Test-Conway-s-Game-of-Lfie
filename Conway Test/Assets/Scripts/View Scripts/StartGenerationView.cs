using UnityEngine;
using UnityEngine.UI;

namespace View_Scripts
{
    public class StartGenerationView : MonoBehaviour
    {
        [SerializeField] private Button m_startGeneration;

        private void Awake()
        {
            m_startGeneration.onClick.AddListener(() =>
            {
                GameManger.Instance.StartGeneration();
            });
        }
    }
}
