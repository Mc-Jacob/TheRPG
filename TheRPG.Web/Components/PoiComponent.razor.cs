using Microsoft.AspNetCore.Components;
using TheRPG.Core;
namespace TheRPG.Web.Components;

public partial class PoiComponent : ComponentBase
{
    [Parameter] 
    public required PointOfInterest PointOfInterest { get; set; }
    
}