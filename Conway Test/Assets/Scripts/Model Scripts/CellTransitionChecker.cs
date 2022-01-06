
public class CellTransitionChecker
{
    private int m_aliveCellCounter;

    public void ResetAliveCellCounter()
    {
        m_aliveCellCounter = 0;
    }
    
    public void AddAliveCellCounter()
    {
        m_aliveCellCounter++;
    }

    public CellType ProcessTransitionCondition(CellType p_ownerCellType)
    {
        if (p_ownerCellType == CellType.Alive)
        {
            //underpopulation transition
            if (m_aliveCellCounter < 2)
            {
                //dead cell
                return CellType.Dead;
            }
            
            // 2 or 3 alive neighbour transition
            if (m_aliveCellCounter >= 2 && m_aliveCellCounter <= 3)
            {
                //alive cell
                return CellType.Alive;
            }
            
            //overpopulation transition
            if (m_aliveCellCounter > 3)
            {
                //dead cell
                return CellType.Dead;
            }
        }
        else
        {
            if (m_aliveCellCounter == 3)
            {
                //alive cell
                return CellType.Alive;
            }
        }

        return CellType.Undetermined;
    }
}
