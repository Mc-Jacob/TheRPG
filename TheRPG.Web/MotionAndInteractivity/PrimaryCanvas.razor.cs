using System.Collections.Specialized;
using System.Timers;
using Microsoft.AspNetCore.Components.Web;
using Timer = System.Timers.Timer;

namespace TheRPG.Web.MotionAndInteractivity;

public partial class PrimaryCanvas : ComponentBase
{
    private readonly int _moveDistance = 10;
    private ElementReference _divElement;
    enum Direction
    {
        Left,
        Right,
        Down,
        Up
    }

    int playerX = 50;
    private int playerY = 50;

    [Inject] public IJSRuntime? JsRuntime { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var aTimer = new Timer();
            aTimer.Elapsed += new ElapsedEventHandler(TestMotion);
            // Set the Interval to 16 milliseconds.  Note: Time is set in Milliseconds
            aTimer.Interval = 16;
            aTimer.Enabled = true;
            if (JsRuntime is not null)
            {
                await JsRuntime.InvokeVoidAsync("canvasInterop.setupCanvas");
            }
        }
    }

    private void MovePlayer(Direction dir)
    {
        switch(dir)
        {
            case Direction.Down:
                playerY += _moveDistance;
                break;
            case Direction.Left:
                playerX -= _moveDistance;
                break;
            case Direction.Right:
                playerX += _moveDistance;
                break;
            case Direction.Up:
                playerY -= _moveDistance;
                break;
            default:
                break;
        }
    }

    private async void TestMotion(object? o, ElapsedEventArgs args)
    {
        await JsRuntime!.InvokeVoidAsync("drawPlayer", [playerX, playerY]);
    }
    
    
}