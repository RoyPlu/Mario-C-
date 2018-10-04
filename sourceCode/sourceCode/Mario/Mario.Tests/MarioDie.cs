using GameEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mario.Tests
{
    [TestClass]
    public class MarioDie
    {
        [TestMethod]
        public void DyingTest()
        {
            var game = new GameObject("Mario");
            ResourceManager.Instance.LoadSpriteSheetFromFile("sm-mario-sprites", @"resources\sm-mario-sprites.png", 10);
            ResourceManager.Instance.LoadFontFromFile("arial", @"resources\arial.ttf");
            var s = new MainScene(game) { Name = "play" };
            game.SceneManager.AddScene(s);
            var mario = new Characters.Mario(game);
            mario.Die();
            var lifesLeft = ((MainScene)game.SceneManager.CurrentScene).PlayerLives;
            Assert.AreEqual(lifesLeft, 2);
        }
    }
}
