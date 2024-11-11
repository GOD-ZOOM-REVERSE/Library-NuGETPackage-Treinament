using ClassLibrary1.Hypermedia.Abstract;
using System.Collections.Generic;

namespace ClassLibrary1.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
