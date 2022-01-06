 using System.Collections.Generic;
using Controller_Scripts;
using Sirenix.OdinInspector;
using UnityEngine;
using View_Scripts;

namespace Model_Scripts
{
    public class CellItemModel : MonoBehaviour
    {
        [SerializeField] private CellItemView m_cellItemView;

        [SerializeField] private CellType m_ownerCellType = CellType.Dead;

        [ShowInInspector] private CellTransitionChecker m_cellTransitionChecker = new CellTransitionChecker();
        [ShowInInspector] private readonly List<CellItemController> m_cellNeighbours = new List<CellItemController>();
        
        public void SetCellRandomStatus(bool p_isAlive)
        {
            m_ownerCellType = CellType.Alive;

            if (p_isAlive)
            {
                m_ownerCellType = CellType.Alive;
                m_cellItemView.UpdateCellColor(GameManger.Instance.CellColorController.AliveCellColor);
            }
            else
            {
                m_ownerCellType = CellType.Dead;
                m_cellItemView.UpdateCellColor(GameManger.Instance.CellColorController.DeadCellColor);
            }
        }
        

        public void PopuplateNeighbours(CellItemController p_cellItem)
        {
            m_cellNeighbours.Add(p_cellItem);
        }

        public void ProcessGenerationChange()
        {
            m_cellTransitionChecker.ResetAliveCellCounter();
            
            foreach (CellItemController cellItem in m_cellNeighbours)
            {
                if (cellItem.CellItemModel.m_ownerCellType == CellType.Alive)
                {
                    m_cellTransitionChecker.AddAliveCellCounter();
                }
            }

            CheckCellTransition();
        }

        private void CheckCellTransition()
        {
            CellType cellType = m_cellTransitionChecker.ProcessTransitionCondition(m_ownerCellType);
            
            if (cellType != CellType.Undetermined)
            {
                m_ownerCellType = cellType;
                if (m_ownerCellType == CellType.Alive)
                {
                    GameManger.Instance.CurrentDataSectionController.AddivingCellCount();
                    m_cellItemView.UpdateCellColor(GameManger.Instance.CellColorController.AliveCellColor);
                }
                else
                {
                    m_cellItemView.UpdateCellColor(GameManger.Instance.CellColorController.DeadCellColor);
                }
            }
            else
            {
                // cell type is undetermined
            }
        }
        
    }
}
