using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {


        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(.10, water.Price);
        }
        //Ice
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }
        //Size
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }
        //Calories
        [Fact]
        public void ShoudHaveDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectDefualtLemonProperty()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }
   
        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(.10, water.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(.10, water.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }



        //That invoking AddIce() results in the Ice property being True.
        [Fact]
        public void ShouldSetIcePropertyToFalse()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        [Fact]
        public void ShouldSetLemonPropertyToTrue()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }
        //Should have correct ingredients
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);

        }
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Water water = new Water();
            Assert.Equal("Small Water", water.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Water water = new Water();
            Assert.Empty(water.Special);
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Collection<string>(water.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }
        [Fact]
        public void holdIceShouldAddToSpecial()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.Collection<string>(water.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }
        [Fact]
        public void holdIceAndAddLemonShouldAddToSpecial()
        {
            Water water = new Water();
            water.HoldIce();
            water.AddLemon();
            Assert.Collection<string>(water.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            },
            item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }
      
        [Fact]
        public void AddLemonShouldNotifySpecialChange()
        {

            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () => water.AddLemon());
        }
        [Fact]
        public void HoldIceShouldNotifySpecialChange()
        {

            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () => water.HoldIce());
        }
    }
}