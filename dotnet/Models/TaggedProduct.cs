using System;
using System.Linq;

namespace DotNetService.Models
{
    public class TaggedProduct
    {
        public int Id { get; }
        public string Name { get;}

        public TaggedProduct(Product product) => (Id, Name) = (1, "hola");
    }
}