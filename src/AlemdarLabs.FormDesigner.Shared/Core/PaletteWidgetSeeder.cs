using AlemdarLabs.FormDesigner.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlemdarLabs.FormDesigner.Core
{
    public static class PaletteWidgetSeeder
    {
        private static List<PaletteWidgetDto> _paletteWidgetList;

        static PaletteWidgetSeeder()
        {
            _paletteWidgetList = new List<PaletteWidgetDto>()
            {
                new PaletteWidgetDto()
                {
                    Id = Guid.NewGuid(),
                    Name = "Single Line",
                    ComponentType = ComponentType.SingleLine,
                    Description = "This is a single line component",
                    Order = 1,
                    Visible = true,
                    Icon = @"<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 50 20'><g><path d='M 1,19 1,1 49,1 49,19 Z M 0,0 0,20 50,20 50,0 Z' style='fill:#000000'/></g><path style='fill:#000000;fill-opacity:1;stroke:none;stroke-width:0.5;stroke-miterlimit:4;stroke-dasharray:none;stroke-opacity:1' d='m 5.4382875,15.181544 3.838384,0 0,0.707071 -3.838384,0 z m -0.112826,-11.259453 3.838384,0 0,0.707071 -3.838384,0 z m 2.429338,11.975342 -1.062012,0 0,-11.889647 1.062012,0 z'/></svg>",
                },
                new PaletteWidgetDto()
                {
                    Id = Guid.NewGuid(),
                    Name = "Multi Line",
                    ComponentType = ComponentType.MultiLine,
                    Description = "This is a multi line component",
                    Order = 2,
                    Visible = true,
                    Icon = @"<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 50 20'><g fill='#000'><path d='M1 19V1h48v18H1zM0 0v20h50V0H0z'/><path d='m 47,17 1,0 0,1 -1,0 z m 0,-3 1,0 0,1 -1,0 z m -1,1 1,0 0,1 -1,0 z m -1,1 1,0 0,1 -1,0 z m -1,1 1,0 0,1 -1,0 z m -2,-1 1,0 0,1 -1,0 z m -1,1 1,0 0,1 -1,0 z m 2,-2 1,0 0,1 -1,0 z m 1,-1 1,0 0,1 -1,0 z m 1,-1 1,0 0,1 -1,0 z m 1,-1 1,0 0,1 -1,0 z m 1,-1 1,0 0,1 -1,0 z'/></g><path style='fill:#000000;fill-opacity:1;stroke:none;stroke-width:0.5;stroke-miterlimit:4;stroke-dasharray:none;stroke-opacity:1' d='m 5.9480411,15.443605 3.838384,0 0,0.707071 -3.838384,0 z m -0.112826,-11.259453 3.838384,0 0,0.7070707 -3.838384,0 z m 2.429338,11.975342 -1.062012,0 0,-11.8896472 1.062012,0 z'/></svg>",
                },
                new PaletteWidgetDto()
                {
                    Id = Guid.NewGuid(),
                    Name = "Link",
                    ComponentType = ComponentType.Link,
                    Description = "This is a link component",
                    Order = 3,
                    Visible = true,
                    Icon = @"<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 50 20'><g style='display:inline' /><path fill='none'/>\&quot;#000\&quot; stroke-miterlimit='10' d='M0 0v20h50V0H0zm1 19V1h31v18H1zM33 1h16v18H33V1zm8.2 14.1l5.2-5.2c1.3-1.3.9-3.6.1-4.4-1.2-1.2-3.7-1-5 .4-1.9 1.9-5 5.1-5 5.1s-2.5 2.5-.8 4.2c1.4 1.4 4.1-1.2 4.1-1.2L45 8.7s1-1.3.2-2c-.9-.8-2.3.3-2.3.3l-3.3 3.3'/&gt;<g style='display:inline'><path style='fill:url(#linearGradient4145);fill-opacity:1;stroke:#000000;stroke-width:1;stroke-opacity:1' d='m 0.5,0.5 49,0 0,19 -49,0 z'/><text xml:space='preserve' style='font-style:normal;font-weight:normal;font-size:12.5px;line-height:0%;font-family:sans-serif;letter-spacing:0px;word-spacing:0px;fill:#000000;fill-opacity:1;stroke:none;stroke-width:1px;stroke-linecap:butt;stroke-linejoin:miter;stroke-opacity:1' x='5.9533944' y='14.139818'><tspan x='5.9533944' y='14.139818'>http://</tspan></text><path style='fill:none;fill-opacity:1;stroke:#000000;stroke-width:0.40000001;stroke-miterlimit:4;stroke-dasharray:none;stroke-opacity:1' d='m 36.452761,3.8366899 0,0.07822 4.761719,0 0,-0.07822 -4.761719,0 z' /><path style='fill:none;fill-opacity:1;stroke:#000000;stroke-width:0.40000001;stroke-miterlimit:4;stroke-dasharray:none;stroke-opacity:1' d='m 38.679324,4.2849819 0,10.9679121 0.0918,0 0,-10.9679121 -0.0918,0 z'/><path style='fill:none;fill-opacity:1;stroke:#000000;stroke-width:0.40000001;stroke-miterlimit:4;stroke-dasharray:none;stroke-opacity:1' d='m 36.411841,15.400363 0,0.07995 4.761718,0 0,-0.07995 -4.761718,0 z' /></g></svg>",
                },
                new PaletteWidgetDto()
                {
                    Id = Guid.NewGuid(),
                    Name = "Email",
                    ComponentType = ComponentType.Email,
                    Description = "This is an email component",
                    Order = 4,
                    Visible = true,
                    Icon = @"<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 50 20'><path d='m 0.49999999,0.49999999 0,19.00000001 48.99999901,0 0,-19.00000001 z M 40.876,14.845 45.971999,9.9050004 c 1.274,-1.2350006 0.882,-3.4200005 0.098,-4.1800005 -1.175998,-1.14 -3.625999,-0.95 -4.899998,0.3800001 C 39.307999,7.9099999 36.27,10.95 36.27,10.95 c 0,0 -2.45,2.375 -0.784001,3.99 1.372002,1.329999 4.018001,-1.140001 4.018001,-1.140001 l 5.096001,-5.0349991 c 0,0 0.979998,-1.235 0.196001,-1.9 C 43.914001,6.105 42.542,7.1499999 42.542,7.1499999 l -3.234,3.1349991' style='fill:none;stroke:#000000;stroke-width:0.99999994;stroke-miterlimit:10'/><rect style='fill:none;fill-opacity:1;stroke:#000000;stroke-width:0.89999998;stroke-miterlimit:10;stroke-dasharray:none;stroke-opacity:1' width='0.2020202' height='18.484848' x='32.101009' y='1.1111112' /><rect style='fill:#fffeff;fill-opacity:1;stroke:none;stroke-width:1.1;stroke-miterlimit:4;stroke-dasharray:none;stroke-opacity:1' width='14.242424' height='14.545455' x='33.434345' y='2.4242425' rx='1.9271899' ry='1.9271899' /><text xml:space='preserve' style='font-style:normal;font-weight:normal;font-size:13.75px;line-height:0%;font-family:sans-serif;letter-spacing:0px;word-spacing:0px;fill:#000000;fill-opacity:1;stroke:none;stroke-width:1px;stroke-linecap:butt;stroke-linejoin:miter;stroke-opacity:1' x='35.151516' y='12.939606'><tspan id='tspan4146' x='35.151516' y='12.939606' style='font-size:12.5px'>@</tspan></text><g style='font-style:normal;font-weight:normal;font-size:12.5px;line-height:0%;font-family:sans-serif;letter-spacing:0px;word-spacing:0px;fill:#000000;fill-opacity:1;stroke:none;stroke-width:1px;stroke-linecap:butt;stroke-linejoin:miter;stroke-opacity:1'/><path style='fill:#000000;fill-opacity:1;stroke:none;stroke-width:0.5;stroke-miterlimit:4;stroke-dasharray:none;stroke-opacity:1' d='m 5.9644042,15.25572 3.8383839,0 0,0.707071 -3.8383839,0 z M 5.8515788,3.9962666 l 3.8383839,0 0,0.7070707 -3.8383839,0 z m 2.4293377,11.9753424 -1.0620117,0 0,-11.8896476 1.0620117,0 0,11.8896476 z'/></svg>"
                },
                new PaletteWidgetDto()
                {
                    Id = Guid.NewGuid(),
                    Name = "Checkbox",
                    ComponentType = ComponentType.Checkbox,
                    Description = "This is a checkbox component",
                    Order = 5,
                    Visible = true,
                    Icon = @"<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 50 20'><g transform='matrix(0.99916422,0,0,1.1015534,0.60342786,-1.0355393)' style='fill:#000000;fill-opacity:1;stroke-width:0.09531885;stroke-miterlimit:4;stroke-dasharray:none'><path d='m 0.35714286,18.45 -0.0714286,-16.6428571 48.35714274,0 L 48.5,18.468404 Z m -1.00511228,-17.5280889 0.005112,18.1377729 50.00511242,0.01841 0.0316,-18.0138043 z m 19.87759142,9.3892209 4,4.000001 8,-7.0000007 -1.7,-1.7 -6.5,6.2000007 -2.8,-2.8000007 z' style='fill:#000000;fill-opacity:1;stroke-width:0.09531885;stroke-miterlimit:4;stroke-dasharray:none'/></g><rect style='fill:none;fill-opacity:1;stroke:#000000;stroke-width:1.10000002;stroke-miterlimit:4;stroke-dasharray:none;stroke-opacity:1' width='14.772384' height='12.169996' x='18.369804' y='3.7733393' /><g style='stroke-width:0.3;stroke-miterlimit:4;stroke-dasharray:none;stroke:#000000;stroke-opacity:1'><path d='M 1,19 1,1 49,1 49,19 Z M 0,0 0,20 50,20 50,0 Z' style='fill:#000000;stroke-width:0.3;stroke-miterlimit:4;stroke-dasharray:none;stroke:#000000;stroke-opacity:1'/></g></svg>"
                },
                new PaletteWidgetDto()
                {
                    Id = Guid.NewGuid(),
                    Name = "Number",
                    ComponentType = ComponentType.Number,
                    Description = "This is a number component",
                    Order = 6,
                    Visible = true,
                    Icon = @"<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 50 20'><g><path d='M 1,19 1,1 49,1 49,19 Z M 0,0 0,20 50,20 50,0 Z' style='fill:#000000' /></g><text xml:space='preserve' style='font-style:normal;font-weight:normal;font-size:12.5px;line-height:0%;font-family:sans-serif;letter-spacing:0px;word-spacing:0px;fill:#000000;fill-opacity:1;stroke:none;stroke-width:1px;stroke-linecap:butt;stroke-linejoin:miter;stroke-opacity:1' x='10.418741' y='14.342195'><tspan x='10.418741' y='14.342195' style='font-size:12.5px'>123</tspan></text><path style='fill:none;fill-opacity:1;stroke:#000000;stroke-width:0.40000001;stroke-miterlimit:4;stroke-dasharray:none;stroke-opacity:1' d='m 30.324153,3.7643341 0,0.078219 4.761719,0 0,-0.078219 -4.761719,0 z'/><path style='fill:none;fill-opacity:1;stroke:#000000;stroke-width:0.40000001;stroke-miterlimit:4;stroke-dasharray:none;stroke-opacity:1' d='m 32.550716,4.2126262 0,10.9679118 0.0918,0 0,-10.9679118 -0.0918,0 z' /><path style='fill:none;fill-opacity:1;stroke:#000000;stroke-width:0.40000001;stroke-miterlimit:4;stroke-dasharray:none;stroke-opacity:1' d='m 30.283233,15.328007 0,0.07995 4.761718,0 0,-0.07995 -4.761718,0 z'/></svg>"
                },
                new PaletteWidgetDto()
                {
                    Id = Guid.NewGuid(),
                    Name = "File",
                    ComponentType = ComponentType.File,
                    Description = "This is a file component",
                    Order = 7,
                    Visible = true,
                    Icon = @"<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 50 20'><path d='m 0.49999999,0.49999999 0,19.00000001 48.99999901,0 0,-19.00000001 z M 40.876,14.845 45.971999,9.9050004 c 1.274,-1.2350006 0.882,-3.4200005 0.098,-4.1800005 -1.175998,-1.14 -3.625999,-0.95 -4.899998,0.3800001 C 39.307999,7.9099999 36.27,10.95 36.27,10.95 c 0,0 -2.45,2.375 -0.784001,3.99 1.372002,1.329999 4.018001,-1.140001 4.018001,-1.140001 l 5.096001,-5.0349991 c 0,0 0.979998,-1.235 0.196001,-1.9 C 43.914001,6.105 42.542,7.1499999 42.542,7.1499999 l -3.234,3.1349991' style='fill:none;stroke:#000000;stroke-width:0.99999994;stroke-miterlimit:10'/><rect style='fill:none;fill-opacity:1;stroke:#000000;stroke-width:0.89999998;stroke-miterlimit:10;stroke-dasharray:none;stroke-opacity:1' width='0.2020202' height='18.484848' x='32.101009' y='1.1111112' /></svg>"
                },
                new PaletteWidgetDto()
                {
                    Id = Guid.NewGuid(),
                    Name = "DateTime",
                    ComponentType = ComponentType.DateTime,
                    Description = "This is a date time component",
                    Order = 8,
                    Visible = true,
                    Icon = @"<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 50 20'><g><path d='M 1,19 1,1 49,1 49,19 Z M 0,0 0,20 50,20 50,0 Z' style='fill:#000000'/></g><path d='m 18.831443,4.9521838 0,-1.8395886 c 0,-0.254678 0.253574,-0.4593295 0.569138,-0.4593295 0.315564,0 0.569141,0.2046515 0.569141,0.4593295 l 0,1.8395886 c 0,0.2546794 -0.253577,0.4593294 -0.569141,0.4593294 -0.315564,0 -0.569138,-0.20465 -0.569138,-0.4593294 z m 9.683859,0.4593294 c 0.312748,0 0.569145,-0.20465 0.569145,-0.4593294 l 0,-1.8395886 c 0,-0.254678 -0.256397,-0.4593295 -0.569145,-0.4593295 -0.315565,0 -0.571962,0.2046515 -0.571962,0.4593295 l 0,1.8395886 c 0,0.2546794 0.256397,0.4593294 0.571962,0.4593294 z m 6.263339,8.2747358 c 0,2.030612 -2.039871,3.679177 -4.55594,3.679177 -2.516036,0 -4.555942,-1.648565 -4.555942,-3.679177 0,-2.030583 2.039906,-3.676904 4.555942,-3.676904 2.516069,0 4.55594,1.646321 4.55594,3.676904 z m -1.138253,0 c 0,-1.521225 -1.532747,-2.758239 -3.417687,-2.758239 -1.884905,0 -3.417652,1.237014 -3.417652,2.758239 0,1.521255 1.532747,2.75827 3.417652,2.75827 1.88494,0 3.417687,-1.237015 3.417687,-2.75827 z M 21.108,8.1697731 l -2.276557,0 0,1.8395719 2.276557,0 0,-1.8395719 z m -2.276557,4.5978409 2.276557,0 0,-1.839604 -2.276557,0 0,1.839604 z m 3.417665,-2.758269 2.276544,0 0,-1.8395719 -2.276544,0 0,1.8395719 z m 0,2.758269 2.276544,0 0,-1.839604 -2.276544,0 0,1.839604 z m -4.558765,0.827678 0,-6.344184 12.532358,0 0,1.8372994 1.138287,0 0,-3.5859372 c 0,-0.5571082 -0.549422,-1.0096128 -1.231268,-1.0096128 l -0.476166,0 0,0.4593264 c 0,0.5070819 -0.509938,0.9186528 -1.138252,0.9186528 -0.628313,0 -1.141108,-0.4115709 -1.141108,-0.9186528 l 0,-0.4593264 -6.835338,0 0,0.4593264 c 0,0.5070819 -0.509966,0.9186528 -1.138275,0.9186528 -0.628305,0 -1.138279,-0.4115709 -1.138279,-0.9186528 l 0,-0.4593264 -0.476162,0 c -0.681845,0 -1.23408,0.4525046 -1.23408,1.0096128 l 0,8.0928218 c 0,0.557111 0.552235,1.011896 1.23408,1.011896 l 6.739512,0 0,-0.920939 -6.739512,0 c -0.05071,0 -0.0958,-0.04321 -0.0958,-0.09095 z m 10.252997,-3.585947 0,-1.8395719 -2.276581,0 0,1.8395719 2.276581,0 z m 3.989612,3.676904 -1.710251,0 0,-1.377967 c 0,-0.254681 -0.25358,-0.461607 -0.569147,-0.461607 -0.315565,0 -0.569107,0.206926 -0.569107,0.461607 l 0,1.8373 c 0,0.254679 0.253542,0.459331 0.569107,0.459331 l 2.279398,0 c 0.312748,0 0.569146,-0.204652 0.569146,-0.459331 0,-0.252406 -0.256398,-0.459333 -0.569146,-0.459333 z' style='fill:#000000;fill-opacity:1;fill-rule:nonzero;stroke:none' /></svg>"
                },
                new PaletteWidgetDto()
                {
                    Id = Guid.NewGuid(),
                    Name = "Tabs",
                    ComponentType = ComponentType.Tabs,
                    Description = "This is a tabs component",
                    Order = 9,
                    Visible = true,
                    Icon = @"<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 50 20'><path fill='#000' d='M50,11.4V8.6h-1v2.9H50z M50,16.2v-2.9h-1v2.9H50z M49,20h1v-1.9h-1v1V20z M44.1,20h2.9v-1h-2.9V20zM39.2,20h2.9v-1h-2.9V20z M34.3,20h2.9v-1h-2.9V20z M29.4,20h2.9v-1h-2.9V20z M24.5,20h2.9v-1h-2.9V20z M19.6,20h2.9v-1h-2.9V20zM14.7,20h2.9v-1h-2.9V20z M9.8,20h2.9v-1H9.8V20z M4.9,20h2.9v-1H4.9V20z M0,18.1V20h2.9v-1H1v-1H0z M0,13.3v2.9h1v-2.9H0zM0,8.6v2.9h1V8.6H0z M0,1v5.7h1V1H0z M15.7,0H1v1h14.7V0z M16.7,1h-1v4.8h2v-1h-1V1z M22.5,4.8h-2.9v1h2.9V4.8z M27.5,4.8h-2.9v1h2.9V4.8z M32.4,4.8h-2.9v1h2.9V4.8z M37.3,4.8h-2.9v1h2.9V4.8z M42.2,4.8h-2.9v1h2.9V4.8z M47.1,4.8h-2.9v1h2.9V4.8z M50,4.8h-1v1v1h1V4.8z'/><path fill='#CBD5E1' d='M34.3,1h-1v3.8h1V1z M18.6,1h14.7V0H18.6V1z M18.6,4.8V1h-1v3.8H18.6z'/></svg>"
                }
            };
        }

        public static List<PaletteWidgetDto> GetPaletteWidgets()
        {
            return _paletteWidgetList;
        }

        public static PaletteWidgetDto GetPaletteWidget(ComponentType componentType)
        {
            var paletteWidget = _paletteWidgetList.FirstOrDefault(pw => 
                pw.ComponentType == componentType);

            return paletteWidget;
        }
    }
}
