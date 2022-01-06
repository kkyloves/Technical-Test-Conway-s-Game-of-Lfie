namespace Model_Scripts
{
    public class LivingCellCounterModel
    {
        public int GetLivingCellCount { get; private set; }


        public void AddLivingCellCounter()
        {
            GetLivingCellCount++;
        }

        public void ResetLivingCellCounter()
        {
            GetLivingCellCount = 0;
        }

    }
}
