using System;

namespace AlemdarLabs.FormDesigner.Models
{
    public class ContainerBaseDto
    {
        public ContainerBaseDto()
        {
            Id = Guid.NewGuid();
            Type = ContainerType.Base;
        }
        public ContainerBaseDto(Guid id)
        {
            Id = id;
            Type = ContainerType.Base;
        }
        public ContainerBaseDto(Guid id, ContainerType type) : this(id)
        {
            Type = type;
        }
        public ContainerBaseDto(ContainerType type)
        {
            Id = Guid.NewGuid();
            Type = type;
        }

        public Guid Id { get; private set; }
        public ContainerType Type { get; private set; }
    }
}
