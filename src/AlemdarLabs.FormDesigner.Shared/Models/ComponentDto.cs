using AlemdarLabs.FormDesigner.Core;
using System;
using System.Collections.Generic;

namespace AlemdarLabs.FormDesigner.Models
{
    public class ComponentDto : ComponentBaseDto
    {
        public ComponentDto()
        {
            Type = ComponentType.SingleLine;
            Label = $"{Type.GetName()}-{Guid.NewGuid()}";
        }

        public ComponentDto(ComponentType type)
        {
            InitializeComponent(type);
        }

        public ComponentDto(Guid id, ComponentType type) : base(id)
        {
            InitializeComponent(type);
        }

        internal void InitializeComponent(ComponentType type)
        {
            Type = type;
            Label = $"{Type.GetName()}-{Guid.NewGuid()}";

            if (Type == ComponentType.Tabs)
            {
                ChildContainers = new List<ContainerDto>()
                {
                    new ContainerDto(ContainerType.Tab)
                    {
                        Label = "Tab 1"
                    }
                };
            }
        }

        public ComponentDto Parent { get; set; }
        public ComponentType Type { get; private set; }

        public string Label { get; set; }

        //// component has row and column info if it is a widget
        //public int? Row { get; set; }
        //public int? Column { get; set; }

        //// component has order and title info if it is a tab widget
        //public int? Order { get; set; }
        //public string TabTitle { get; set; }

        public List<ContainerDto> ChildContainers { get; set; }

        private int width = ComponentUtils.MaxColumnWidth;
        public int Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    width = 0;
                }
                else if (value > 12)
                {
                    width = 12;
                }
                else
                {
                    width = value;
                }
            }
        }
    }
}
