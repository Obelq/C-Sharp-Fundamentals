using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            //Act
            axe.Attack(dummy);

            //Assert
            Assert.AreEqual(9, axe.DurabilityPoints);
        }

        [Test]
        public void WeaponShouldNotBeAbleToAttackWhenIsBroken()
        {
            //Arrange
            Axe axe = new Axe(1, 1);
            Dummy dummy = new Dummy(10, 10);

            //Act
            axe.Attack(dummy);

            //Assert
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}
