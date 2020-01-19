using NUnit.Framework;
using System;

//Implement and Test a system for a supermarket checkout that calculates the total price of scanned items.
//Items are priced individually but special offers may apply on certain items.Offers apply when multiple items are 
//purchased together, although they can be scanned out of order. BOGOF is Buy One Get One Free.
//Barcode Price   Offer
//Apple	  50	3 for 120
//Banana  20	5 for 80
//Carrot  15	
//Turnip  75	BOGOF

namespace ShoppingCartKata
{
    [TestFixture]
    public class ShoppingCartTests
    {
        [Test]
        public void WhenOneOfEachIsScannedTotalIs160()
        {
            var subject = new ShoppingCart();
            subject.Scan("1111");
            subject.Scan("2222");
            subject.Scan("3333");
            subject.Scan("4444");
            Assert.That(subject.Basket(), Is.EqualTo(160));
        }      
        [Test]
        public void WhenOneAppleisScannedAppleThenTotalIs50()
        {
            var subject = new ShoppingCart();
            subject.Scan("1111");
            Assert.That(subject.Basket(), Is.EqualTo(50));
        }
        [Test]
        public void WhenTwoApplesAreScannedThenTotalIs100()
        {
            var subject = new ShoppingCart();
            subject.Scan("1111");
            subject.Scan("1111");
            Assert.That(subject.Basket(), Is.EqualTo(100));
        }
        [Test]
        public void WhenThreeApplesAreScannedThenTotalIs120()
        {
            var subject = new ShoppingCart();
            subject.Scan("1111");
            subject.Scan("1111");
            subject.Scan("1111");
            Assert.That(subject.Basket(), Is.EqualTo(120));
        }
        [Test]
        public void WhenFourApplesAreScannedThenTotalIs170()
        {
            var subject = new ShoppingCart();
            subject.Scan("1111");
            subject.Scan("1111");
            subject.Scan("1111");
            subject.Scan("1111");
            Assert.That(subject.Basket(), Is.EqualTo(170));
        }
        [Test]
        public void WhenSixApplesAreAddedThenTotalIs240()
        {
            var subject = new ShoppingCart();
            subject.Scan("1111");
            subject.Scan("1111");
            subject.Scan("1111");
            subject.Scan("1111");
            subject.Scan("1111");
            subject.Scan("1111");
            Assert.That(subject.Basket(), Is.EqualTo(240));
        }
        [Test]
        public void WhenAnAppleAndABananaAreScannedAnAppleAndABananaAreAdded()
        {
            var subject = new ShoppingCart();
            subject.Scan("1111");
            subject.Scan("2222");
            Assert.That(subject.Basket(), Is.EqualTo(70));
        }
        [Test]
        public void WhenAnAppleAndABananaAreScannedAlternatelyUntilDiscountIsTriggeredThenTotalIsEqualTo200()
        {
            var subject = new ShoppingCart();
            subject.Scan("1111");
            subject.Scan("2222");
            subject.Scan("1111");
            subject.Scan("2222");
            subject.Scan("1111");
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            Assert.That(subject.Basket(), Is.EqualTo(200));
        }
        [Test]
        public void WhenOneBananaThenTotalIs20()
        {
            var subject = new ShoppingCart();
            subject.Scan("2222");
            Assert.That(subject.Basket(), Is.EqualTo(20));
        }
        [Test]
        public void WhenFourBananasAreScannedThenTotalIs80()
        {
            var subject = new ShoppingCart();
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            Assert.That(subject.Basket(), Is.EqualTo(80));
        }
        [Test]
        public void WhenFiveBananasAreScannedThenTotalIs80()
        {
            var subject = new ShoppingCart();
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            Assert.That(subject.Basket(), Is.EqualTo(80));
        }
        [Test]
        public void WhenSixBananasAreScannedThenTotalIs100()
        {
            var subject = new ShoppingCart();
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            Assert.That(subject.Basket(), Is.EqualTo(100));
        }
        [Test]
        public void WhenTenBananasAreScannedThenTotalIs160()
        {
            var subject = new ShoppingCart();
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            subject.Scan("2222");
            Assert.That(subject.Basket(), Is.EqualTo(160));
        }
        [Test]
        public void WhenOneCarrotisScannedThenTotalIs15()
        {
            var subject = new ShoppingCart();
            subject.Scan("3333");
            Assert.That(subject.Basket(), Is.EqualTo(15));
        }
        [Test]
        public void WhenTwoCarrotsAreScannedThenTotalIs30()
        {
            var subject = new ShoppingCart();
            subject.Scan("3333");
            subject.Scan("3333");
            Assert.That(subject.Basket(), Is.EqualTo(30));
        }
        [Test]
        public void WhenOneTurnipIsScannedThenTotalIs75()
        {
            var subject = new ShoppingCart();
            subject.Scan("4444");
            Assert.That(subject.Basket(), Is.EqualTo(75));
        }    
        [Test]
        public void WhenTwoTurnipsAreScannedThenTotalIs75()
        {
            var subject = new ShoppingCart();
            subject.Scan("4444");
            subject.Scan("4444");
            Assert.That(subject.Basket(), Is.EqualTo(75));
        }
        [Test]
        public void WhenThreeTurnipsAreScannedThenTotalIs150()
        {
            var subject = new ShoppingCart();
            subject.Scan("4444");
            subject.Scan("4444");
            subject.Scan("4444");
            Assert.That(subject.Basket(), Is.EqualTo(150));
        }
        [Test]
        public void WhenFourTurnipsAreScannedThenTotalIs150()
        {
            var subject = new ShoppingCart();
            subject.Scan("4444");
            subject.Scan("4444");
            subject.Scan("4444");
            subject.Scan("4444");
            Assert.That(subject.Basket(), Is.EqualTo(150));
        }
    }
}