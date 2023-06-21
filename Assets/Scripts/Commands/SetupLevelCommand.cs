public class SetupLevelCommand : ICommand
{

    public void Execute()
    {
        App.screenManager.Show<InGameScreen>();
        Events.onGameStarted.Invoke();
    }
}
