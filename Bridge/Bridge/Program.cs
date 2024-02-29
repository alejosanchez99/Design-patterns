using Bridge.Example1;

IFormat mp3Format = new Mp3();
MusicPlayer musicPlayer = new DesktopPlayer(mp3Format);

musicPlayer.Play("song.mp3");

IFormat wavFormat = new Wav();
musicPlayer = new DesktopPlayer(wavFormat);

musicPlayer.Play("song.wav");

