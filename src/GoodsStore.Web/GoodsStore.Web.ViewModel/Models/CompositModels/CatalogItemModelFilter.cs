using System.Collections.Generic;

namespace GoodsStore.Web.ViewModel.Models.CompositModels
{
    public class CatalogItemModelFilter
    {
        public string TypeDiscriminator { get; set; }
        public int LoadedCount { get; set; }
        public PhraseModelFilter[] PhraseModelFilters { get; set; }
        public RangeModelFilter[] RangeModelFilters { get; set; }
        public GroupModelFilter[] GroupModelFilters { get; set; }

        public IEnumerable<BaseModelFilter> GetFilledlFilters()
        {
            var res = new List<BaseModelFilter>();
            foreach (var phraseModelFilter in PhraseModelFilters)
            {
                if (!string.IsNullOrWhiteSpace(phraseModelFilter.Value))
                {
                    res.Add(phraseModelFilter);
                }
            }
            
            foreach (var rangeModelFilter in RangeModelFilters)
            {
                if (rangeModelFilter.FromValue.HasValue || rangeModelFilter.ToValue.HasValue)
                {
                    res.Add(rangeModelFilter);
                }
            }

            foreach (var groupModelFilter in GroupModelFilters)
            {
                if (groupModelFilter.Values != null && groupModelFilter.Values.Length != 0)
                {
                    res.Add(groupModelFilter);
                }
            }
            return res;
        }
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
        public double? FromValue { get; set; }
        public double? ToValue { get; set; }
    }

    public class GroupModelFilter : BaseModelFilter
    {
        public int[] Values { get; set; }
    }
}