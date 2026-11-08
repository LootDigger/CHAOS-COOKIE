using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

public class CakeLimitShiftTest
{
    [UnityTest]
    public IEnumerator CakeLimitTestWithEnumeratorPasses()
    {
        yield return null;

        int cakeLimitShift = 10;
        ADScoreCounter adScoreCounter = new(cakeLimitShift);
        adScoreCounter.ShiftScoreLimit();
        Assert.AreEqual(adScoreCounter.ScoreLimit, 2*cakeLimitShift);
    }
}
