using Model_Scripts;
using UnityEngine;
using View_Scripts;

namespace Controller_Scripts
{
    public class CellItemController : MonoBehaviour
    {
        [SerializeField] private CellItemView m_cellItemView;
        [SerializeField] private CellItemModel m_cellItemModel;

        public CellItemModel CellItemModel => m_cellItemModel;

        public void InitCellItem()
        {
            
        }
    }
}
