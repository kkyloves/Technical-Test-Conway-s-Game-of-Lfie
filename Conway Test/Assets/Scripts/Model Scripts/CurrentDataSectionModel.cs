namespace Model_Scripts
{
    public class CurrentDataSectionModel
    {
        private readonly LivingCellCounterModel m_livingCellCounterModel = new LivingCellCounterModel();
        private readonly GenerationCountModel m_generationCounterModel = new GenerationCountModel();
        
        public void AddLivingCellCount()
        {
            m_livingCellCounterModel.AddLivingCellCounter();
        }
        
        public void ResetLivingCellCount()
        {
            m_livingCellCounterModel.ResetLivingCellCounter();
        }

        public int GetLivingCellCount()
        {
            return m_livingCellCounterModel.GetLivingCellCount;
        }
        
        public void AddGenerationCellCount()
        {
            m_generationCounterModel.AddGenerationCount();
        }

        public void ResetGenerationCount()
        {
            m_generationCounterModel.ResetGenerationCount();
        }
        
        public int GetGenerationCount()
        {
            return m_generationCounterModel.GetGenerationCount;
        }
    }
}
