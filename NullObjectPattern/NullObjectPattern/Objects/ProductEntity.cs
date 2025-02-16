
using System.Xml.Linq;

namespace NullObjectPattern.Objects
{
    public class ProductEntity : IProductEntity
    {
        public int Id { get; }
        public string Name { get; }

        public TimeSpan OperatingTime
        {
            get
            {
                // Temporary implementation simulating communication with the product
                Random random = new Random();
                double operatingTime = (double)(random.Next(0, 10000));
                return TimeSpan.FromSeconds(operatingTime);
            }
        }

        public ProductEntity(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
