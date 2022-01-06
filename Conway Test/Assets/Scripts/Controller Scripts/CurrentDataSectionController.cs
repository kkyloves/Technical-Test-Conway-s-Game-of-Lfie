using Model_Scripts;
using UnityEngine;

namespace Controller_Scripts
{
    public class CurrentDataSectionController : MonoBehaviour
    {
        [SerializeField] private CurrentDataSectionView m_currentDataSectionView;

        private readonly CurrentDataSectionModel m_currentDataSectionModel = new CurrentDataSectionModel();
        public void AddivingCellCount()
        {
            m_currentDataSectionModel.AddLivingCellCount();
            m_currentDataSectionView.UpdateLivingCountText(m_currentDataSectionModel.GetLivingCellCount());
        }

        public void ResetLivingCellCount()
        { 
            m_currentDataSectionModel.ResetLivingCellCount();
        }

        public void AddGenerationCount()
        {
            m_currentDataSectionModel.AddGenerationCellCount();
            m_currentDataSectionView.UpdateGenerationCountText(m_currentDataSectionModel.GetGenerationCount());
        }

        public void ResetGenerationCount()
        {
            m_currentDataSectionModel.ResetGenerationCount();
        }
    }
}
