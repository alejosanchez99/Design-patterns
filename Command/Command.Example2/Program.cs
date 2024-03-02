
using Command.Example2;

SmartTV smartTV = new SmartTV();
RemoteControl remoteControl = new RemoteControl();

remoteControl.SetCommand(new AmazonCommand(smartTV));
remoteControl.PressButton();

remoteControl.SetCommand(new NetflixCommand(smartTV));
remoteControl.PressButton();