using System.Collections.Generic;
using Controller_Scripts;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Model_Scripts
{
    public class CellGridItemsStorageModel : MonoBehaviour
    {
        [SerializeField] private CellGridController m_cellGridController;
        [ShowInInspector] public List<CellItemController> CellItemStorage { get; } = new List<CellItemController>();

        public void PopulateCellItemStorage(CellItemController p_cellItemController)
        {
            CellItemStorage.Add(p_cellItemController);
        }
        
        public void PopuplateNeighbours()
        {
            for (int i = 0; i < CellItemStorage.Count; i++)
            {
                CellItemController currentCellItem = CellItemStorage[i];

                //left neighbour
                int leftIndex = i - 1;
                if (leftIndex >= 0)
                {
                    currentCellItem.CellItemModel.PopuplateNeighbours(CellItemStorage[leftIndex]);
                }
                
                //right neighbour
                int rightIndex = i + 1;
                if (rightIndex <  CellItemStorage.Count)
                {
                    currentCellItem.CellItemModel.PopuplateNeighbours(CellItemStorage[rightIndex]);
                }
                
                //up neighbour
                int upIndex = i - m_cellGridController.GetGridRowCount();
                if (upIndex >= 0)
                {
                    currentCellItem.CellItemModel.PopuplateNeighbours(CellItemStorage[upIndex]);
                }
                
                //down neighbour
                int downIndex = i + m_cellGridController.GetGridRowCount();
                if (downIndex < CellItemStorage.Count)
                {
                    currentCellItem.CellItemModel.PopuplateNeighbours(CellItemStorage[downIndex]);
                }
                
                //up left neighbour
                int upLeftIndex = upIndex - 1;
                if (upLeftIndex >= 0)
                {
                    currentCellItem.CellItemModel.PopuplateNeighbours(CellItemStorage[upLeftIndex]);
                }
                
                //down left neighbour
                int downLeftIndex = downIndex - 1;
                if (downLeftIndex < CellItemStorage.Count)
                {
                    currentCellItem.CellItemModel.PopuplateNeighbours(CellItemStorage[downLeftIndex]);
                }
                
                //up left neighbour
                int upRightIndex = upIndex + 1;
                if (upRightIndex >= 0)
                {
                    currentCellItem.CellItemModel.PopuplateNeighbours(CellItemStorage[upRightIndex]);
                }
                
                //down left neighbour
                int downRightIndex = downIndex + 1;
                if (downRightIndex < CellItemStorage.Count)
                {
                    currentCellItem.CellItemModel.PopuplateNeighbours(CellItemStorage[downRightIndex]);
                }
            }
        }

        public void CleanCellItemStorage()
        {
            if (CellItemStorage.Count > 0)
            {
                foreach (CellItemController cellItemController in CellItemStorage)
                {
                    Destroy(cellItemController.gameObject);
                }
                
                CellItemStorage.Clear();
            }
        }
    }
}
