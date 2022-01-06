using Controller_Scripts;
using Sirenix.OdinInspector;
using UnityEngine;
using View_Scripts;

namespace Model_Scripts
{
    public class CellGridModel : MonoBehaviour
    {
        [SerializeField] private CellGridController m_cellGridController;
        [SerializeField] private CellGridInstantiateView m_cellGridInstantiate;
        
        [ShowInInspector] public int RowCount { get; set; }
        [ShowInInspector] public int ColumnCount { get; set; }

        private const float m_cellSize = 0.5f;

        public void PopulateGrid()
        {
            for (int i = 0; i < ColumnCount; i++)
            {
                for (int j = 0; j < RowCount; j++)
                {
                    float posX = j * m_cellSize;
                    float posY = i * -m_cellSize;
                    
                    m_cellGridInstantiate.InstantiateCellGridItem(posX, posY, m_cellSize);
                }
            }

            float gridCellWidth = RowCount * m_cellSize;
            float gridCellHeight = ColumnCount * m_cellSize;
            m_cellGridInstantiate.gameObject.transform.localPosition = new Vector2(-gridCellWidth / 2 + m_cellSize / 2, gridCellHeight / 2 - m_cellSize / 2);
            
            m_cellGridController.PopulateCellGridNeighbours();
        }
    }
}
