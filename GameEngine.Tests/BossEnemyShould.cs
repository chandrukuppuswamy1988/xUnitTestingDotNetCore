﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
namespace GameEngine.Tests
{
    public class BossEnemyShould
    {

        private ITestOutputHelper _output;


        public BossEnemyShould(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        [Trait("Category","Boss")]
        public void HaveCorrectPower()
        {

            _output.WriteLine("Creating Boss Enemy");

            BossEnemy sut = new BossEnemy();

            Assert.Equal(166.667, sut.TotalSpecialAttackPower, 3);
        }
    }
}
