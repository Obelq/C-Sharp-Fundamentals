using Moq;
using NUnit.Framework;
using Skeleton.Interfaces;

namespace Skeleton.Tests
{
    [TestFixture]
    public class HeroTests
    {
        private Mock<IWeapon> weapon;
        private Mock<ITarget> target;

        [SetUp]
        public void TestInit()
        {
            weapon = new Mock<IWeapon>();
            target = new Mock<ITarget>();
        }

        [Test]
        public void HeroGainsXpWhenTargetDies()
        {
            //Arrange
            weapon.SetupGet(x => x.AttackPoints).Returns(10);
            weapon.SetupGet(x => x.DurabilityPoints).Returns(10);

            target.Setup(x => x.GiveExperience()).Returns(10);
            target.Setup(x => x.IsDead()).Returns(true);

            var sut = new Hero("Kiro", weapon.Object);

            //Act
            sut.Attack(target.Object);

            //Assert
            Assert.AreEqual(10, sut.Experience);
        }
        
    }
}