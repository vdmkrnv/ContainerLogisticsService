using System.ComponentModel;

namespace BusModels;

public class OrderDeleted
{
    public List<Guid> ContainerIds { get; set; }
}