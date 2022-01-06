using Controller_Scripts;
using Model_Scripts;
using UnityEngine;
using Utils;

public class GameManger : SingletonBehaviour<GameManger>
{
   [SerializeField] private CellGridController m_cellGridController;
   [SerializeField] private CurrentDataSectionController m_currentDataSectionController;
   [SerializeField] private GenerationController m_generationController;
   [SerializeField] private CameraController m_cameraController;
   
   public CellColorController CellColorController = new CellColorController();
   public CellGridController CellGridController => m_cellGridController;
   public CurrentDataSectionController CurrentDataSectionController => m_currentDataSectionController;
   public GenerationController GenerationController => m_generationController;

   public void StartGeneration()
   {
      m_cellGridController.PopulateCellGrid();
      m_generationController.StartGeneration();
      m_cameraController.UpdateCameraLimitaion();
   }
}
