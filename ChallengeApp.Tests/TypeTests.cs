namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void testTypReference()
        {
            //arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Tomasz");

            //act

            // assert
            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void testTypeValueNumber()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            //act

            // assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void testTypeValueFloat()
        {
            //arrange
            float numflo1 = 1.2234f;
            float numflo2 = 2.3254f;

            //act

            // assert
            Assert.AreNotEqual(numflo1, numflo2);
        }

        [Test]
        public void testTypeValueString()
        {
            //arrange
            var str1 = "Anna";
            var str2 = "Michal";

            //act

            // assert
            Assert.AreNotEqual(str1, str2);
        }

        [Test]
        public void testTypeValueBool()
        {
            //arrange
            var bool1 = true;
            var bool2 = true;

            //act

            // assert
            Assert.AreEqual(bool1, bool2);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
