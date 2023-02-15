const qrScanner = window.qrcode;
const video = document.createElement("video");
const canvasElement = document.getElementById("qr-canvas");
const canvas = canvasElement.getContext("2d");
const btnScanQR = document.getElementById("btn-scan-qr");
const divScanQR = document.getElementById('div-scan-qr');
const btnStopScan = document.getElementById('btn-stop-scan');

let scanning = false;

btnScanQR.onclick = () => {
    navigator.mediaDevices
        .getUserMedia({ video: { facingMode: "environment" } })
        .then(function (stream) {
            scanning = true;
            divScanQR.hidden = true;
            canvasElement.hidden = false;
            btnStopScan.hidden = false;
            video.setAttribute("playsinline", true); // required to tell iOS safari we don't want fullscreen
            video.srcObject = stream;
            video.play();
            tick();
            scan();
        });
};

function tick() {
    canvasElement.height = video.videoHeight;
    canvasElement.width = video.videoWidth;
    canvas.drawImage(video, 0, 0, canvasElement.width, canvasElement.height);
    scanning && requestAnimationFrame(tick);
}

function scan() {
    try {
        qrScanner.decode();
    } catch (e) {
        setTimeout(scan, 300);
    }
}

btnStopScan.onclick = () => {
    hideScanner();
};

function hideScanner() {
    scanning = false;
    video.srcObject.getTracks().forEach(track => {
        track.stop();
    });
    canvasElement.hidden = true;
    divScanQR.hidden = false;
    btnStopScan.hidden = true;
}