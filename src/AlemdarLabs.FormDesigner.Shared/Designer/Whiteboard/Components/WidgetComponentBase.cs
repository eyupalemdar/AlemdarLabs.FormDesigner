using AlemdarLabs.FormDesigner.Models;
using Microsoft.AspNetCore.Components;

namespace AlemdarLabs.FormDesigner.Designer.Whiteboard.Components
{
    public partial class WidgetComponentBase : ComponentBase
    {
        [Parameter]
        public ComponentDto Component { get; set; }

        public WidgetComponentBase()
        {

        }
    }
}
