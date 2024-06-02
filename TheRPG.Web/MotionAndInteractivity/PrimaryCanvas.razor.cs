namespace TheRPG.Web.MotionAndInteractivity;

public partial class PrimaryCanvas : ComponentBase
{
    [Inject] public IJSRuntime? JsRuntime { get; set; }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (JsRuntime is not null)
            {
                await JsRuntime!.InvokeVoidAsync("canvasInterop.setupCanvas");
            }
        }
    }
}