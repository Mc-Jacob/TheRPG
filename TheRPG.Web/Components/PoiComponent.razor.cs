namespace TheRPG.Web.Components;

public partial class PoiComponent : ComponentBase
{
    private List<PointOfInterest> _pois = [];
    private PointOfInterest? _selectedPoiValue;
    protected override Task OnInitializedAsync()
    {
        _pois.Add(TreasureChest);
        _pois = GetAllPoIs();
        return base.OnInitializedAsync();
    }

    private void OnPoiChange(ChangeEventArgs args)
    {
        _selectedPoiValue = _pois.FirstOrDefault(x => x.Introduction == args?.Value!.ToString());
        InvokeAsync(StateHasChanged);
    }
}