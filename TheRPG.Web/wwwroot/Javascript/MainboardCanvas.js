const a = 2 * Math.PI / 6;
const r = 20;
let x = 50;
let y = 50;
let canvas;
let context;
let player;

window.canvasInterop = {
    setupCanvas: function () {
        let width = 1280;
        let height = 720;
        canvas = document.getElementById("primaryCanvas");
        context = canvas.getContext("2d");
        canvas.width = width;
        canvas.height = height;
        player = {
            radius: 12,
            color: "blue",
            draw(xx, yy) {
                context.clearRect(0,0,800,600);
                context.beginPath();
                context.arc(xx, yy, this.radius, 0, Math.PI * 2, true);
                context.fillStyle = this.color;
                context.closePath();
                context.fill();
            },
        };
        drawPlayArea(0,0, 800, 600, context);
        requestAnimationFrame(player.draw);
        // setInterval(drawPc(x,y,10, 0, 2*Math.PI, context), 16);

        // context.fillRect(10, 10, 100, 100);
        //  for (let y = r; y + r * Math.sin(a) < height; y += r * Math.sin(a)) {
        //      for (let x = r, j = 0; x + r * (1 + Math.cos(a)) < width; x += r * (1 + Math.cos(a)), y += (-1) ** j++ * r * Math.sin(a)) {
        //          drawHexagon(x, y, context);
        //      }
        //  }
    }
};

function drawPlayer(x, y){
    player.draw(x, y);
}

function drawHexagon(x, y, context) {
    context.beginPath();
    for (let i = 0; i < 6; i++) {
        context.lineTo(x + r * Math.cos(a * i), y + r * Math.sin(a * i));
    }
    context.closePath();
    context.stroke();
}

function drawPlayArea(x, y, height, width, context) {
    context.beginPath();
    context.rect(x, y, height, width)
    context.stroke();
}

function drawPc(x, y, r, sAngle, eAngle, context) {
    context.beginPath();
    context.arc(x, y, r,sAngle, eAngle);
    context.closePath();
    x+=10;
    y+=10;
}
