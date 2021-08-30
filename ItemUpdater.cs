namespace csharpcore

{
    public abstract class ItemUpdater
    {
        public abstract void UpdateItem(Item item);
    }

    public class SulfurasUpdater : ItemUpdater
    {
        public override void UpdateItem(Item item)
        {
        }
    }


    public class BackstageUpdater : ItemUpdater
    {
        public override void UpdateItem(Item item)
        {
            item.IncreaseQualityIfNotMax();

            if (item.SellIn <= 10)
            {
                item.IncreaseQualityIfNotMax();
            }

            if (item.SellIn <= 5)
            {
                item.IncreaseQualityIfNotMax();
            }


            item.DecreaseSellIn();

            if (item.SellIn < 0)
            {
                item.ResetQuality();
            }
        }
    }


    public class DefaultUpdater : ItemUpdater
    {
        public override void UpdateItem(Item item)
        {
            item.DecreaseQualityIfNotMin();

            item.DecreaseSellIn();

            if (item.SellIn < 0)
            {
                item.DecreaseQualityIfNotMin();
            }
        }
    }

    public class AgedBrieUpdater : ItemUpdater
    {
        public override void UpdateItem(Item item)
        {
            item.IncreaseQualityIfNotMax();


            item.DecreaseSellIn();

            if (item.SellIn < 0)
            {
                item.IncreaseQualityIfNotMax();
            }
        }
    }
}