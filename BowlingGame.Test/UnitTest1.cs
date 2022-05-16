using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void une_Partie_Commence_Avec_Un_Score_De_Zero()
        {
			var partie = new Partie();

			Assert.AreEqual(0, partie.Score());

		}
    }
}