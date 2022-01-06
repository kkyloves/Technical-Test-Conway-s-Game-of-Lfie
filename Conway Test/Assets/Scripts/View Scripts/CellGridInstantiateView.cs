using Controller_Scripts;
using UnityEngine;

namespace View_Scripts
{
    public class CellGridInstantiateView : MonoBehaviour
    {
        [SerializeField] private CellGridController m_cellGridController;
        [SerializeField] private GameObject m_cellGridItemPrefab;

        public void InstantiateCellGridItem(float p_positionX, float p_positionY, float p_cellSize)
        {
            GameObject cell = Instantiate(m_cellGridItemPrefab.gameObject, transform);
            cell.transform.localPosition = new Vector2(p_positionX, p_positionY);
            //cell.transform.localScale  = new Vector2(p_cellSize * 2, p_cellSize * 2);
            
            m_cellGridController.PopulateCellGridItemsStorage(cell.GetComponent<CellItemController>());
        }
    }
}
