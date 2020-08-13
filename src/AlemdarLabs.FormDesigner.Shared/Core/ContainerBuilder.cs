using AlemdarLabs.FormDesigner.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlemdarLabs.FormDesigner.Core
{
    public class ContainerBuilder
    {
        public async Task<ContainerDto> BuildContainer(
            List<ComponentDto> componentList)
        {
            ContainerDto container = null;

            if (componentList == null || componentList.Count == 0)
            {
                container = new ContainerDto();
                return await Task.FromResult(container);
            }

            var rootComponents = GetRootComponents(componentList, null);
                        return await Task.FromResult(container);
        }

        private List<ComponentDto> GetRootComponents(List<ComponentDto> componentList, Guid? parentComponentId)
        {
            List<ComponentDto> rootComponents = new List<ComponentDto>();

            // Reverse iterate to be able to remove element from the same array
            for (int index = componentList.Count - 1; index >= 0; index++)
            {
                if (parentComponentId == null && componentList[index].Parent == null ||
                    componentList[index].Parent != null && componentList[index].Parent.Id == parentComponentId)
                {
                    // Add item to begining of the root component list
                    rootComponents.Insert(0, componentList[index]);

                    // remove item from component list to decrease iterations 
                    // for further operations
                    componentList.RemoveAt(index);
                }
            }

            return rootComponents;
        }
    }
}
