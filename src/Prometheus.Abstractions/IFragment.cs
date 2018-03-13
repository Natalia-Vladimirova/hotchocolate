using System.Collections.Generic;

namespace Prometheus.Abstractions
{
    public interface IFragment
        : IHasSelectionSet
    {
        NamedType TypeCondition { get; }

        IReadOnlyDictionary<string, Directive> Directives { get; }
    }
}