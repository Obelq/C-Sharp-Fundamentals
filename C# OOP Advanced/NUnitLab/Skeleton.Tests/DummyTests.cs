using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyMustLoseHealthIfAttacked()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);

            //Act
            dummy.TakeAttack(9);

            //Assert
            Assert.AreEqual(1, dummy.Health);
        }

        [Test]
        public void DeadDummyMustThrowExceptionIfAttacked()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);

            //Act
            dummy.TakeAttack(10);


            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(1));
            Assert.AreEqual("Dummy is dead.", ex.Message);
        }

        [Test]
        public void DeadDummyShouldGiveXP()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);


            //Act
            dummy.TakeAttack(10);
            int xp = dummy.GiveExperience();

            //Assert
            Assert.AreEqual(10, xp);
        }

        [Test]
        public void AliveDummyShouldNotGiveXP()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);


            //Act

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.AreEqual("Target is not dead.", ex.Message);
        }
    }
}
