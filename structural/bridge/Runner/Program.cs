// See https://aka.ms/new-console-template for more information
using Bridge;
var remote = new RemoteControl(new Radio());
remote.VolumeUp();
var advRemote = new AdvancedRemoteControl(new TV());
advRemote.VolumeDown();
advRemote.Mute();