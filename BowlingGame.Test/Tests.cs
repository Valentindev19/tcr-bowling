using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BowlingGame.Test
{
	public class Tests
    {
        [TestMethod]
        public void MethodeExemple()
        {
            var partie = new Partie();
            partie.TesterPartie();

            Assert.AreEqual(0, 87);
        }
    }
}
