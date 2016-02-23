using System;
using MediaValet.Core.DDD;

namespace SampleBoundedContext.Models.Asset
{
    public class AssetId : ValueObject<AssetId>
    {
        private readonly int _hashCode;

        public AssetId(Guid id)
        {
            Id = id;
            _hashCode = new { Id }.GetHashCode();
        }

        public Guid Id
        {
            get;
        }
        public override int GetHashCode()
        {
            return _hashCode;
        }

        public override string ToString()
        {
            return $"{GetType()}[{Id}]";
        }

        public override bool Equals(AssetId other)
        {
            return other != null && Id.Equals(other.Id);
        }
    }
}