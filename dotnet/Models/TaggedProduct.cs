using System;
using System.Linq;

namespace DotNetService.Models
{
    public class TaggedProduct
    {
        public Boolean Success { get; }

        public TaggedProduct(Product product) => (Success) = (true);
    }
}