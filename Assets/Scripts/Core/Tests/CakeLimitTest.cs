using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

public class CakeLimitTest
{
    [UnityTest]
    public IEnumerator CakeLimitTestWithEnumeratorPasses()
    {
        yield return null;

        int cakeLimitShift = 10;
        ADScoreCounter adScoreCounter = new(cakeLimitShift);
        Assert.AreEqual(adScoreCounter.ScoreLimit,cakeLimitShift);
    }
}
