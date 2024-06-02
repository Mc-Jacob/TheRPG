namespace TheRPG.Web.Components;

public partial class PoiComponent : ComponentBase
{
    [Parameter] 
    public required PointOfInterest PointOfInterest { get; set; }
    
    private List<PointOfInterest> _pois = [];
    protected override Task OnInitializedAsync()
    {
        _pois.Add(TreasureChest);
        _pois = GetAllPoIs();
        return base.OnInitializedAsync();
    }
}