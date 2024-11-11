namespace ChallengeApp.Tests
{
    public class Tests1
    {
        [Test]
        public void AddScoreAndCheckSummationforEmployee()
        {
            //arrange
            Employee employee1 = new Employee("Julia", "Nowak", 20);
            employee1.AddScore(5);
            employee1.AddScore(2);
            employee1.AddScore(1);
            employee1.AddScore(2);
            employee1.AddScore(4);

            //act
            var result = employee1.Result;


            //assert
            Assert.AreEqual(14, result);
        }

        [Test]
        public void AddScoreAndCheckSummationNegativeNumbersforEmployee()
        {
            //arrange
            Employee employee1 = new Employee("Julia", "Nowak", 20);
            employee1.AddScore(-5);
            employee1.AddScore(-2);
            employee1.AddScore(-1);
            employee1.AddScore(-2);
            employee1.AddScore(-4);
            employee1.AddScore(0);

            //act
            var result = employee1.Result;


            //assert
            Assert.AreEqual(-14, result);
        }



    }
}