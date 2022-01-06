using Model_Scripts;
using UnityEngine;
using View_Scripts;

namespace Controller_Scripts
{
    public class CellGridController : MonoBehaviour
    {
        [SerializeField] private CellGridModel m_cellGridModel;
        [SerializeField] private CellGridInstantiateView m_cellGridView;
        [SerializeField] private CellGridItemsStorageModel m_cellGridItemsStorageModel;
        
        public CellGridModel CellGridModel => m_cellGridModel;
        public CellGridInstantiateView CellGridInstantiateView => m_cellGridView;
        public CellGridItemsStorageModel CellGridItemsStorageModel => m_cellGridItemsStorageModel;
        
        public void PopulateCellGrid()
        {
            m_cellGridItemsStorageModel.CleanCellItemStorage();
            m_cellGridModel.PopulateGrid();
        }
        
        public void PopulateCellGridItemsStorage(CellItemController p_cellItemController)
        {
            m_cellGridItemsStorageModel.PopulateCellItemStorage(p_cellItemController);
        }

        public void PopulateCellGridNeighbours()
        {
            m_cellGridItemsStorageModel.PopuplateNeighbours();
        }

        public int GetGridRowCount()
        {
            return m_cellGridModel.RowCount;
        }
        
        public int GetGridColumnCount()
        {
            return m_cellGridModel.ColumnCount;
        }
        
        public void SetGridRowCount(int p_count)
        {
            m_cellGridModel.RowCount = p_count;
        }
        
        public void SetGridColumnCount(int p_count)
        {
            m_cellGridModel.ColumnCount = p_count;
        }

        public float GetGridCellSize()
        {
            return m_cellGridModel.ColumnCount;
        }

    }
}
