﻿using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace MenuTest.Drinks
{
    public class JurasicJavaTest 
    {
        

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<double>(.59, java.Price);
        }
        //Ice
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Ice);
        }
        //Size
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }
        //Calories
        [Fact]
        public void ShoudHaveDefaultCalories()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<uint>(2, java.Calories);
        }
        [Fact]
        public void ShouldHaveProperDefaultSpaceForCream()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.RoomForCream);
        }
        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(.59, java.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(.99, java.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }
        //That invoking AddIce() results in the Ice property being True.
        [Fact]
        public void ShouldSetIcePropertyToTrue()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        [Fact]
        public void ShouldMakeSpaceForCream()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }
        //Should have correct ingredients
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);


        }
        [Fact]
        public void ShouldHaveCorrectToString()
        {
            JurrasicJava java = new JurrasicJava();
            java.MakeDecaf();
            java.Size = Size.Medium;
            Assert.Equal("Medium Decaf Jurrasic Java", java.ToString());
        }
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal("Small Jurrasic Java", java.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Empty(java.Special);
        }

        [Fact]
        public void LeaveRoomForCreamShouldAddToSpecial()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.Collection<string>(java.Special, item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
        }
        [Fact]
        public void AddIceShouldAddToSpecial()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.Collection<string>(java.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }
        [Fact]
        public void MakeDecafShouldAddToDescription()
        {
            JurrasicJava java = new JurrasicJava();
            java.MakeDecaf();
            Assert.Equal("Small Decaf Jurrasic Java", java.Description);
        }
        [Fact]
        public void LeaveRoomForCreamShouldNotifySpecialChange()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.PropertyChanged(java, "Special", () => java.LeaveRoomForCream());
            

        }
       

    }
}