﻿namespace WebRtcNet
{
    /// <summary>
    /// MediaTrackSettings represents the Settings of an IMediaStreamTrack object.
    /// <seealso cref="http://www.w3.org/TR/mediacapture-streams/#media-track-settings"/>
    /// </summary>
    public struct MediaTrackSettings
    {
        public int Width;
	    public int Height;
        public double AspectRatio;
        public double FrameRate;
        public string facingMode;
        public double Volume;
        public int SampleRate;
        public int SampleSize;
        public bool EchoCancellation;
        public double Latency;
        public int ChannelCount;
        public string deviceId;
        public string groupId;
    };
}
