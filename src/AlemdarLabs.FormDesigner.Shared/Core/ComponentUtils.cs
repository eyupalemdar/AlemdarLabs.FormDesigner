using AlemdarLabs.FormDesigner.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlemdarLabs.FormDesigner.Core
{
    public class ComponentUtils
    {
        public const int MaxColumnWidth = 12;
        public const string BlankIconDataString = @"<svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 50 20""></svg>";

        public static string GetComponentColumnCssClasses(ComponentDto componentData)
        {
            return $@"col-{CalculateColumnWidth(componentData)}";
        }

        public static int CalculateColumnWidth(ComponentDto componentData)
        {
            return componentData?.Width ?? MaxColumnWidth;
        }

        public static void ComputeEachItemSizeInRow(List<ComponentDto> componentInRow)
        {
            double columnSize = Math.Floor((double)(MaxColumnWidth / componentInRow.Count));
            double lastColumnSize = MaxColumnWidth % columnSize;

            int rowSize = componentInRow.Aggregate(0, (colSize, component) => colSize + component.Width);
            var lastComponent = componentInRow.Last();

            if (rowSize < MaxColumnWidth)
            {
                // last component will fill remaining space
                lastComponent.Width = MaxColumnWidth;
                return;
            }
            else
            {
                //we iterate over the component to resize  them
                foreach (var component in componentInRow)
                {
                    component.Width = (int)columnSize;
                }

                // We stop if all column size are equal and there rest is 0
                if (lastColumnSize == 0)
                {
                    return;
                }

                // we distribute the rest of number-of-components / 12 to
                // columns starting from the end
                for (int index = componentInRow.Count - (int)lastColumnSize; index < componentInRow.Count - 1; index++)
                {
                    componentInRow[index].Width += 1;
                }
            }
        }
        public static string GetIconDataString(string iconAsString)
        {
            string encodedIconDataString = Uri.EscapeDataString(string.IsNullOrEmpty(iconAsString) ? BlankIconDataString : iconAsString);
            string iconDataString = $@"data:image/svg+xml,{encodedIconDataString}";
            return iconDataString;
        }
    }
}
