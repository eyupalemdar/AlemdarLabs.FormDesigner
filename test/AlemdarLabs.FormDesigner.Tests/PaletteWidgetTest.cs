using Bunit;
using Bunit.TestDoubles.JSInterop;
using AlemdarLabs.FormDesigner.Core;
using AlemdarLabs.FormDesigner.Designer.Palette;
using AlemdarLabs.FormDesigner.Models;
using Xunit;

namespace AlemdarLabs.FormDesigner.Tests
{
    public class PaletteWidgetTest : TestContext
    {
        [Fact(DisplayName = "Palette widget with null data")]
        public void TestPaletteWidget_NullWidget()
        {
            // Arrange
            PaletteWidgetDto widgetItem = null;

            // Act
            var cut = RenderComponent<PaletteWidget>(
                (nameof(PaletteWidget.WidgetItem), widgetItem)
                );

            // Assert
            var expectedMarkup =
                @"<p>Widget could not be loaded</p>";
            cut.MarkupMatches(expectedMarkup);
        }

        [Fact(DisplayName = "Palette widget with predefined Single Line data")]
        public void TestPaletteWidget_PredefinedWidget()
        {
            // Arrange

            // Registered the MockJSRuntime in "Loose" mode with the service provider used when rendering components.
            // JSRuntimeMockMode.Loose is the default. It configures the mock to just return the default
            // value for whatever is requested in a InvokeAsync call if no call has explicitly been set up.
            // It is setuped for MatBlazor using inside PaletteWidget.razor
            var jsMock = Services.AddMockJSRuntime();

            PaletteWidgetDto widgetItem = PaletteWidgetSeeder.GetPaletteWidget(ComponentType.SingleLine);

            // Act
            var cut = RenderComponent<PaletteWidget>(
                (nameof(PaletteWidget.WidgetItem), widgetItem)
                );

            // Assert
            var expectedMarkup =
                $@"<div id=""{widgetItem.Id}"" class=""fd-palette-widget text-center draggable"" draggable=""true"">
                        <img class=""fd-palette-widget-icon"" src=""{ComponentUtils.GetIconDataString(widgetItem.Icon)}"">
                        <h5 class=""fd-palette-widget-label"">{widgetItem.Name}</h5>
                   </div>
                   <div class=""mat-tooltip"" style="""" id=""{string.Format("matBlazor_id_{0}", widgetItem.Id)}"" >
                        {widgetItem.Description}
                   </div>";
            cut.MarkupMatches(expectedMarkup);
        }
    }
}
