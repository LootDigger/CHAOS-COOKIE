using Patterns.ServiceLocator;

public class ADScoreCounter
{
   private int _scoreLimit;
   private int _scoreLimitShift;
   private IGameSettingsProvider _gameSettingsProvider;
   
   public int ScoreLimit => _scoreLimit;

   public ADScoreCounter()
   {
      _gameSettingsProvider = ServiceLocator.GetService<IGameSettingsProvider>();
      _scoreLimitShift = _gameSettingsProvider.Settings.ADTriggerScoreLimitShift;
      _scoreLimit = 0;
      ShiftScoreLimit();
   }

   public void ShiftScoreLimit()
   {
      _scoreLimit += _scoreLimitShift;
   }
}
