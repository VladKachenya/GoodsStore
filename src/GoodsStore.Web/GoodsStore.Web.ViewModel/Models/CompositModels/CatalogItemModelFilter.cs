namespace GoodsStore.Web.ViewModel.Models.CompositModels
{
    public class CatalogItemModelFilter
    {
        public string TypeDiscriminator { get; set; }
        public int LoadedCount { get; set; }
        public PhraseModelFilter[] PhraseModelFilters { get; set; }
        public RangeModelFilter[] RangeModelFilters { get; set; }
        public GroupModelFilter[] GroupModelFilters { get; set; }
    }

    public class BaseModelFilter
    {
        public string PropertyName { get; set; }
    }

    public class PhraseModelFilter : BaseModelFilter
    {
        public string Value { get; set; }
    }

    public class RangeModelFilter : BaseModelFilter
    {
        public double FromValue { get; set; }
        public double ToValue { get; set; }
    }

    public class GroupModelFilter : BaseModelFilter
    {
        public int[] Values { get; set; }
    }
}