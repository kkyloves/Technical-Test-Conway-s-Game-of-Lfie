
namespace Model_Scripts
{
    public class GenerationCountModel
    {
        public int GetGenerationCount { get; private set; }

        public void AddGenerationCount()
        {
            GetGenerationCount++;
        }

        public void ResetGenerationCount()
        {
            GetGenerationCount = 0;
        }

    }
}
