using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        private const string AgedBrie = "Aged Brie";
        private const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
        private const string SulfurasHandOfRagnaros = "Sulfuras, Hand of Ragnaros";
        private readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            this._items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                UpdateOneItem(item);
            }
        }

        private ItemUpdater getItemUpdater(Item item)
        {
            return item.Name switch
            {
                AgedBrie => new AgedBrieUpdater(),
                BackstagePasses => new BackstageUpdater(),
                SulfurasHandOfRagnaros => new SulfurasUpdater(),
                _ => new DefaultUpdater()
            };
        }

        private void UpdateOneItem(Item item)
        {
            getItemUpdater(item).UpdateItem(item);
        }
    }
}