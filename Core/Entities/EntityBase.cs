using System;
namespace Core.Entities
{
  public class EntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
