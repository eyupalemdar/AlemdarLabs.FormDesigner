using AlemdarLabs.FormDesigner.Models;

namespace AlemdarLabs.FormDesigner.Extensions
{
    public static class PaletteWidgetDtoExtensions
    {
        public static ComponentDto CreateComponent(this PaletteWidgetDto paletteWidget)
        {
            var componentData = new ComponentDto(paletteWidget.ComponentType);
            return componentData;
        }
    }
}
