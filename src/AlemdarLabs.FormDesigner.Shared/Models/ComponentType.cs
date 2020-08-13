using System;

namespace AlemdarLabs.FormDesigner.Models
{
    public enum ComponentType
    {
        SingleLine = 0,
        MultiLine = 1,
        Link = 2,
        Email = 3,
        Checkbox = 4,
        Number = 5,
        File = 6,
        DateTime = 7,
        Image = 8,
        Choice = 9,
        Tabs = 10
    }

    public static class ComponentTypeExtensions
    {
        public static string GetName(this ComponentType componentType)
        {
            string result = componentType switch
            {
                ComponentType.SingleLine => "Single Line",
                ComponentType.MultiLine => "Multi Line",
                ComponentType.Link => "Link",
                ComponentType.Email => "Email",
                ComponentType.Checkbox => "Check",
                ComponentType.Number => "Number",
                ComponentType.File => "File",
                ComponentType.DateTime => "DateTime",
                ComponentType.Image => "Image",
                ComponentType.Choice => "Choice",
                ComponentType.Tabs => "Tabs",
                _ => throw new NotImplementedException(@$"There is no defined name for '{componentType}'"),
            };
            return result;
        }
    }
}
