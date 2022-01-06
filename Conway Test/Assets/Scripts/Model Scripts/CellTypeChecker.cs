using UnityEngine;

namespace Model_Scripts
{
    public class CellTypeChecker : MonoBehaviour
    {
        public static bool IsCellAlive(CellType p_cellType)
        {
            return p_cellType == CellType.Alive;
        }
    }
}
