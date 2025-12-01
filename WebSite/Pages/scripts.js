; (function () {
 
    var telerikDemo = window.telerikDemo = window.telerikDemo || {},
        INTERVAL_LENGTH = 20,
        MAX_PROGRSS_VALUE = 100,
        MIN_PROGRSS_VALUE = 0,
        PROGRESS_INCREMENT = 1.5,
        channels = ["CNBC", "CNN", "DiscoveryChannel", "ESPN", "Eurosport", "MTV", "NationalGeoraphic", "VH1"],
        tuningProgress = 0,
        isTunningInProgress = false,
        toggleTuningButton,
        tuningProgressBar,
        channelsProgressBar,
        imgNoise,
        imgChannel,
        tuningInterval;
 
    Sys.Application.add_load(function() {
        var $ = $telerik.$;
        imgNoise = $(".imgNoise");
        imgChannel = $(".imgChannel");
    });
 
    //initialize toggleTuningButton
    telerikDemo.toggleTuningButtonLoad = function (sender, args) {
        toggleTuningButton = sender;
    };
 
    //initialize tuningProgressBar
    telerikDemo.tuningProgressBarLoad = function (sender, args) {
        tuningProgressBar = sender;
    };
 
    //initialize channelsProgressBar
    telerikDemo.channelsProgressBarLoad = function (sender, args) {
        channelsProgressBar = sender;
    };
 
    telerikDemo.toggleTuning = function (sender, args) {
        if (args.get_currentToggleState().get_index() == 1) {
            startTuning();
        } else {
            pauseTuning();
        }
    };
 
    telerikDemo.tuningProgressBarValueChanged = function (sender, args) {
        var value = sender.get_value();
        tuneChannel(value);
    };
 
    telerikDemo.tuningProgressBarCompleted = function (sender, args) {
        loadNextChanel();
    };
 
    telerikDemo.channelsProgressBarComplete = function (sender, args) {
        finishTuning();
    };
 
    function startTuning() {
        if (!isTunningInProgress) {
            reset();
            isTunningInProgress = true;
        }
        tuningInterval = setInterval(tune, INTERVAL_LENGTH);
    }
 
    function pauseTuning() {
        clearInterval(tuningInterval);
        tuningInterval = null;
    }
 
    function finishTuning() {
        pauseTuning();
        fadeNoiseOut();
        toggleTuningButton.set_selectedToggleStateIndex(0);
        isTunningInProgress = false;
    }
 
    function tune() {
        tuningProgress += PROGRESS_INCREMENT;
        if (tuningProgress > MAX_PROGRSS_VALUE) {
            ensureTuningCompletion();
            tuningProgress = MIN_PROGRSS_VALUE;
        } else {
            tuningProgressBar.set_value(tuningProgress);
        }
    }
 
    function ensureTuningCompletion() {
        var value = tuningProgressBar.get_value();
        if (value < MAX_PROGRSS_VALUE) {
            tuningProgressBar.set_value(MAX_PROGRSS_VALUE);
        }
    }
 
    function reset() {
        tuningProgressBar.set_value(MIN_PROGRSS_VALUE);
        channelsProgressBar.set_value(0);
        fadeNoiseIn();
        loadChannel(0);
    }
 
    function loadNextChanel() {
        var nextChannelIndex = channelsProgressBar.get_value() + 1;
        channelsProgressBar.set_value(nextChannelIndex);
        loadChannel(nextChannelIndex);
    }
 
    function loadChannel(channelIndex) {
        var channelToLoad = channels[channelIndex];
        if (isTunningInProgress) {
            fadeNoiseIn();
        }
        if (channelToLoad) {
            imgChannel.attr("src", "images/Channels/Channel_" + channelToLoad + ".jpg");
        }
    }
 
    function tuneChannel(value) {
        if (value > 20) {
            if (value < 85) {
                fadeNoiseTo(1 - value / MAX_PROGRSS_VALUE);
            } else {
                fadeNoiseOut();
            }
        }
    }
 
    function fadeNoiseIn() {
        imgNoise.fadeTo(0, 1);
    }
 
    function fadeNoiseOut() {
        imgNoise.fadeTo(0, 0);
    }
 
    function fadeNoiseTo(value) {
        imgNoise.fadeTo(0, value);
    }
})();