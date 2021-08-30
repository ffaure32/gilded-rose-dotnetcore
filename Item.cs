namespace csharpcore
{
    public class Item
    {
        private const int MaxQuality = 50;
        private const int MinQuality = 0;
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void IncreaseQualityIfNotMax()
        {
            if (Quality < MaxQuality)
            {
                Quality += 1;
            }
        }

        public void DecreaseSellIn()
        {
            SellIn -= 1;
        }

        public void DecreaseQualityIfNotMin()
        {
            if (Quality > MinQuality)
            {
                Quality -= 1;
            }
        }

        public void ResetQuality()
        {
            Quality = 0;
        }
    }
}
