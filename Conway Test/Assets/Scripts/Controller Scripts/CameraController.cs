using System;
using Cinemachine;
using UnityEngine;

namespace Controller_Scripts
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CinemachineVirtualCamera m_camera;

        private float m_zoomAmount = 80f;
        private float m_maxZoomAmount = 25f;

        public void UpdateCameraLimitaion()
        {
            //m_maxZoomAmount = GameManger.Instance.CellGridController.GetGridCellSize() * 10;
            //m_camera.m_Lens.OrthographicSize = m_maxZoomAmount;
        }

        private void Update()
        {
            float zoomChangeAmount = 80f;
            if (Input.mouseScrollDelta.y > 0f)
            {
                m_zoomAmount -= zoomChangeAmount * Time.deltaTime * 10f;
            }
            
            if (Input.mouseScrollDelta.y < 0f)
            {
                m_zoomAmount += zoomChangeAmount * Time.deltaTime;
            }

            m_zoomAmount = Mathf.Clamp(m_zoomAmount, 10f, m_maxZoomAmount);
            m_camera.m_Lens.OrthographicSize = m_zoomAmount;
        }
    }
}
