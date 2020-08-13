using AlemdarLabs.FormDesigner.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlemdarLabs.FormDesigner.Core
{
    public class FormDatasourceSeeder
    {
        private readonly ContainerBuilder containerBuilder;

        public FormDatasourceSeeder()
        {
            containerBuilder = new ContainerBuilder();
        }

        //public async Task<ContainerDto> CreateDemoContainerAsync()
        //{
        //    var componentList = await GetDemoDatasourceAsync();
        //    var container = await containerBuilder.BuildContainer(componentList);

        //    return await Task.FromResult(container);
        //}

        // Component list can be stored in a database and
        // fetch it from there with a Web API or Websocket 
        //public async Task<List<ComponentDto>> GetDemoDatasourceAsync()
        //{
        //    var componentList = new List<ComponentDto>()
        //    {
        //        new ComponentDto(ComponentType.SingleLine)
        //        {
        //            Label = "Single Line 1",
        //            Row = 0,
        //            Column = 0
        //        },
        //        new ComponentDto(ComponentType.MultiLine)
        //        {
        //            Label = "Multi Line 1",
        //            Row = 0,
        //            Column = 1
        //        },
        //        new ComponentDto(ComponentType.Number)
        //        {
        //            Label = "Number 1",
        //            Row = 1,
        //            Column = 0
        //        }
        //    };

        //    return await Task.FromResult(componentList);
        //}
    }
}
