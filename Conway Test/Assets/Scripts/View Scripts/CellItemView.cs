using UnityEngine;

namespace View_Scripts
{
    public class CellItemView : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer m_cellSpriteRenderer;

        public void SetCellItemPosition(Vector2 p_position)
        {
            transform.localPosition = p_position;
        }

        public void UpdateCellColor(Color p_color)
        {
            m_cellSpriteRenderer.color = p_color;
        }
    }
}
