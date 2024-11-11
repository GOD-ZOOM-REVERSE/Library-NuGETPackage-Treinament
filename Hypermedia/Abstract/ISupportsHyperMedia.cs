using System.Collections.Generic;

namespace TreinamentoPushNuGet.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
