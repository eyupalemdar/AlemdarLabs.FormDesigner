using AlemdarLabs.FormDesigner.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlemdarLabs.FormDesigner.Extensions
{
    public static class ContainerDtoExtensions
    {
        public static bool IsEmpty(this ContainerDto container)
        {
            bool result = true;

            if (container != null && 
                container.Rows.Any())
            {
                foreach (var row in container.Rows)
                {
                    if (row != null && row.Any())
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        public static async Task RemoveRowAsync(this ContainerDto container,
            List<ComponentDto> row)
        {
            if (container.Rows.Count > 1)
            {
                container.Rows.Remove(row);
            }

            await Task.CompletedTask;
        }
    }
}
