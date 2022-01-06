using HSVPicker;
using UnityEngine;
using UnityEngine.UI;

namespace View_Scripts
{
    public class CellColorPickerView : MonoBehaviour
    {
        [SerializeField] private Button m_aliveCellColorPickerButton;
        [SerializeField] private Button m_deadCellColorPickerButton;
        [SerializeField] private ColorPicker m_colorPickerAliveCell;
        [SerializeField] private ColorPicker m_colorPickerDeadCell;
        [SerializeField] private Button m_aliveCellColorPickerCloseButton;
        [SerializeField] private Button m_deadCellColorPickerCloseButton;
        [SerializeField] private GameObject m_aliveCellColorPickerObj;
        [SerializeField] private GameObject m_deadCellColorPickerObj;

        private void Awake()
        {
            //init default colors
            m_colorPickerAliveCell.AssignColor(Color.white);
            m_colorPickerDeadCell.AssignColor(Color.black);
            
            GameManger.Instance.CellColorController.AliveCellColor = Color.white;
            GameManger.Instance.CellColorController.DeadCellColor = Color.black;
            
            m_aliveCellColorPickerButton.image.color = Color.white;
            m_deadCellColorPickerButton.image.color = Color.black;

            AddListeners();
        }

        private void AddListeners()
        {
            //add listeners
            m_colorPickerAliveCell.onValueChanged.AddListener(color =>
            {
                GameManger.Instance.CellColorController.AliveCellColor = color;
                m_aliveCellColorPickerButton.image.color = color;

            });
            
            m_colorPickerDeadCell.onValueChanged.AddListener(color =>
            {
                GameManger.Instance.CellColorController.DeadCellColor = color;
                m_deadCellColorPickerButton.image.color = color;
            });
            
            m_aliveCellColorPickerButton.onClick.AddListener(() =>
            {
                m_aliveCellColorPickerObj.SetActive(true);
            });
            
            m_deadCellColorPickerButton.onClick.AddListener(() =>
            {
                m_deadCellColorPickerObj.SetActive(true);
            });
            
            m_aliveCellColorPickerCloseButton.onClick.AddListener(() =>
            {
                m_aliveCellColorPickerObj.SetActive(false);
            });        
            
            m_deadCellColorPickerCloseButton.onClick.AddListener(() =>
            {
                m_deadCellColorPickerObj.SetActive(false);
            });    
        }
    }
}
