using System;
using Controller_Scripts;
using UnityEngine;
using Random = UnityEngine.Random;

public class GenerationController : MonoBehaviour
{
    [SerializeField] private CellGridController m_cellGridController;
    
    public float GenerationSpeed { get; set; }
    
    public void StartGeneration()
    {
        GameManger.Instance.CurrentDataSectionController.ResetGenerationCount();
        SetRandomAliveCells();
        ProcessGenerationCount();
    }

    private void ProcessGenerationCount()
    {
        CancelInvoke(nameof(GenerationChange));
        
        if (GenerationSpeed >= 100)
        {
            GenerationSpeed = 99;
        }
        else if (GenerationSpeed <= 0)
        {
            GenerationSpeed = 1;
        }
        
        float modifiedGenSpeed = Mathf.Abs((GenerationSpeed - 100f) / 100f);
        InvokeRepeating(nameof(GenerationChange), 0f, Mathf.Abs(modifiedGenSpeed * 0.1f));
    }

    private void SetRandomAliveCells()
    {
        foreach (CellItemController cellItemController in m_cellGridController.CellGridItemsStorageModel.CellItemStorage)
        {
            int randomNumber = Random.Range(0, 100);
            cellItemController.CellItemModel.SetCellRandomStatus(randomNumber > 75);
        }
    }

    private void GenerationChange()
    {
        GameManger.Instance.CurrentDataSectionController.AddGenerationCount();
        GameManger.Instance.CurrentDataSectionController.ResetLivingCellCount();

        foreach (CellItemController cellItemController in m_cellGridController.CellGridItemsStorageModel.CellItemStorage)
        {
            cellItemController.CellItemModel.ProcessGenerationChange();
        }
    }
    
}
