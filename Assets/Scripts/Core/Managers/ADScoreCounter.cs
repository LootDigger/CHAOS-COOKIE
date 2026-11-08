using Patterns.ServiceLocator;

public class ADScoreCounter
{
   private int _scoreLimit;
   private int _scoreLimitShift;
   
   public int ScoreLimit => _scoreLimit;

   public ADScoreCounter(int scoreLimitShift)
   {
      _scoreLimitShift = scoreLimitShift;
      _scoreLimit = 0;
      ShiftScoreLimit();
   }

   public void ShiftScoreLimit()
   {
      _scoreLimit += _scoreLimitShift;
   }
}
