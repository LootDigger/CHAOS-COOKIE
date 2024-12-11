
public class ADScoreCounter
{
   private int _scoreLimit;
   private int _scoreLimitShift;
   
   public int ScoreLimit => _scoreLimit;

   public ADScoreCounter()
   {
      _scoreLimitShift = 10; // TODO: Get from service locator
      _scoreLimit = 0;
      ShiftScoreLimit();
   }

   public void ShiftScoreLimit()
   {
      _scoreLimit += _scoreLimitShift;
   }
}
