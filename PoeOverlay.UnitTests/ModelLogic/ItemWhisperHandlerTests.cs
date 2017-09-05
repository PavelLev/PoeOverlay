using System;
using System.Linq;
using LightInject;
using Moq;
using NUnit.Framework;
using PoeOverlay.ModelLogic;
using PoeOverlay.Utitlity;

namespace PoeOverlay.UnitTests.ModelLogic
{
    [TestFixture]
    public class ItemWhisperHandlerTests
    {

        [Test]
        public void Handle_AutowhisperIsFalseAndBuyoutIsEmpty_DoingNothing()
        {
            var (itemWhisperHanler, itemSearch, item) = HandleSetUp(false, true);
            
            itemWhisperHanler.Handle(itemSearch, item);

            Assert.AreEqual(0, itemWhisperHanler.ItemsToWhisper.Count);
        }
        [Test]
        public void Handle_AutowhisperIsFalseAndBuyoutIsNotEmpty_DoingNothing()
        {
            var (itemWhisperHanler, itemSearch, item) = HandleSetUp(false, false);

            itemWhisperHanler.Handle(itemSearch, item);

            Assert.AreEqual(0, itemWhisperHanler.ItemsToWhisper.Count);
        }
        [Test]
        public void Handle_AutowhisperIsTrueAndBuyoutIsEmpty_DoingNothing()
        {
            var (itemWhisperHanler, itemSearch, item) = HandleSetUp(true, true);

            itemWhisperHanler.Handle(itemSearch, item);

            Assert.AreEqual(0, itemWhisperHanler.ItemsToWhisper.Count);
        }


        [Test]
        public void Handle_AutowhisperIsTrueAndBuyoutIsNotEmpty_AddingItemToItemsToWhisper()
        {
            var (itemWhisperHanler, itemSearch, item) = HandleSetUp(true, false);

            itemWhisperHanler.Handle(itemSearch, item);

            Assert.AreEqual(item, itemWhisperHanler.ItemsToWhisper.Last());
        }

        public (IItemWhisperHandler itemWhisperHandler, IItemSearch itemSearch, IItem item) HandleSetUp(bool autoWhisper, bool isEmpty)
        {
            var itemWhisperHandler = new ItemWhisperHandler();

            var itemSearchFake = new Mock<IItemSearch>();
            itemSearchFake.SetupGet(itemSearch => itemSearch.AutoWhisper).Returns(autoWhisper);

            var itemFake = new Mock<IItem>();
            itemFake.SetupGet(item => item.Buyout)
                .Returns(() =>
                {
                    var priceFake = new Mock<IPrice>();
                    priceFake.SetupGet(price => price.IsEmpty)
                        .Returns(isEmpty);
                    return priceFake.Object;
                });

            MyServiceContainer.Instance.RegisterInstance(new Mock<INotificationSoundPlayer>().Object);

            return (itemWhisperHandler, itemSearchFake.Object, itemFake.Object);
        }
    }
}