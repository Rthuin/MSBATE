document.addEventListener("DOMContentLoaded", function () {
    var audioPlayers = document.querySelectorAll(".audio-player");
    var playButtons = document.querySelectorAll(".btn-play");

    function togglePlayPause(audio, button) {
        if (audio.paused) {
            audio.play();
            button.innerHTML = "&#9724;"; // "&#9724;" sembolü çalma simgesi (unicode)
        } else {
            audio.pause();
            button.innerHTML = "&#9658;"; // "&#9658;" sembolü duraklatma simgesi (unicode)
        }
    }

    playButtons.forEach(function (button, index) {
        button.addEventListener("click", function () {
            var audio = audioPlayers[index];
            togglePlayPause(audio, button);
        });
    });
});
