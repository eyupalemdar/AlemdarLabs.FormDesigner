using System;

namespace AlemdarLabs.FormDesigner.Models
{
    public class PaletteWidgetDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ComponentType ComponentType { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public string Icon { get; set; }
        public bool Visible { get; set; }
    }
}

//let singleLine = {
//  "name": localization.localize('wpsSingleLineName'),
//  "templateUrl": "single-line-property",
//  "description": localization.localize('wpsSingleLineDesc'),
//  "propertyDataType": entityModel.PropertyDataType.SingleLine,
//  "propertyType": entityModel.WidgetType.SINGLELINE,
//  "buttonWidgetType": -1,
//  "containerType": vm.defaultContainerType,
//  "order": 1,
//  "icon": "<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 50 20'><g><path d='M 1,19 1,1 49,1 49,19 Z M 0,0 0,20 50,20 50,0 Z' style='fill:#000000'/></g><path style='fill:#000000;fill-opacity:1;stroke:none;stroke-width:0.5;stroke-miterlimit:4;stroke-dasharray:none;stroke-opacity:1' d='m 5.4382875,15.181544 3.838384,0 0,0.707071 -3.838384,0 z m -0.112826,-11.259453 3.838384,0 0,0.707071 -3.838384,0 z m 2.429338,11.975342 -1.062012,0 0,-11.889647 1.062012,0 z'/></svg>",
//  "icon_mini": "<svg width='50' height='50' xmlns='http://www.w3.org/2000/svg'><g><title>background</title><rect fill='none' id='canvas_background' height='402' width='582' y='-1' x='-1'/></g><g><title>Layer 1</title><rect stroke='#444444' id='svg_2' height='26.440659' width='49' y='12.918262' x='0.520249' stroke-width='3' fill='none'/><path fill='#444444' stroke-width='1.5' stroke-miterlimit='4' id='path8' d='m7.209435,33.24191l3.83838,0l0,0.9917l-3.83838,0l0,-0.9917zm-0.11283,-15.79186l3.83839,0l0,0.9917l-3.83839,0l0,-0.9917zm2.42934,16.79593l-1.06201,0l0,-16.67574l1.06201,0l0,16.67574z'/><line stroke='#444444' stroke-linecap='null' stroke-linejoin='null' id='svg_8' y2='18.484717' x2='12.159199' y1='18.484717' x1='5.707173' stroke-width='2' fill='none'/><line stroke='#444444' stroke-linecap='null' stroke-linejoin='null' id='svg_10' y2='33.286426' x2='12.28571' y1='33.286426' x1='5.833683' stroke-width='2' fill='none'/><line stroke-linecap='null' stroke-linejoin='null' id='svg_11' y2='34.045488' x2='9.122952' y1='18.864248' x1='8.996441' stroke-width='2' stroke='#444444' fill='none'/></g></svg>",
//  "template": "<div class=\"form-group\">\r\n        <label ng-if=\"!properties.labelHidden\"\r\n      style=\"text-align: right;\"         ng-class=\"{ \'control-label--required\': properties.required }\"\r\n               class=\"control-label col-xs-{{ !properties.labelHidden ? properties.labelWidth : 12 }}\">\r\n            {{ properties.label }}\r\n        <\/label>\r\n        <div class=\"col-xs-{{ 12 - (!properties.labelHidden ? properties.labelWidth : 0) }}\">\r\n\t\t\t\t <div dx-text-box=\"properties.dxOptions\"></div>        <\/div>\r\n    <\/div>\r\n<\/div>",
//  "visible": true
//};