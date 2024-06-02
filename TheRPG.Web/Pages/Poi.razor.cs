namespace TheRPG.Web.Pages;

public partial class Poi : ComponentBase
{
    private List<PointOfInterest?> _pointOfInterests = [];
    
    protected override Task OnInitializedAsync()
    {
        _pointOfInterests = GetAllPoIs();
        return base.OnInitializedAsync();
    }
}