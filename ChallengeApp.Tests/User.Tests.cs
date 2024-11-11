namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void AddScoreAndCheckSummation()
        {
            //arrange
            var user = new User("Mariusz","12345");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(2);
            user.AddScore(0);
            user.AddScore(6);

            //act
            var result = user.Result;


            //assert
            Assert.AreEqual(19, result);
        }

        [Test]
        public void AddScoreAndCheckSummationNegativeNumbers()
        {
            //arrange
            var user = new User("Mariusz", "12345");
            user.AddScore(-5);
            user.AddScore(-6);
            user.AddScore(-2);
            user.AddScore(-0);
            user.AddScore(-6);

            //act
            var result = user.Result;


            //assert
            Assert.AreEqual(-19, result);
        }

        
    }
}