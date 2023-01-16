using Framework;
using Framework.ChiaSeklos;
using NUnit.Framework;

namespace Tests.ChiaSeklosTests
{
    internal class ParduotuveTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Parduotuve.Open();
        }

        [Test]
        public void GoToItemPageByUsingSearch()
        {
            string expectedUrl = "https://chiaseklos.lt/produktas/aguonos/";
            string item = "aguonos";
            
            Parduotuve.ClickBurgerMenu();
            Parduotuve.SendKeysToSearchfield(item);
            Parduotuve.ClickSearchResult();
            string actualUrl = Driver.CurrentPageUrl();

            Assert.AreEqual(expectedUrl, actualUrl);
        }

        [Test]
        public void SearchInvalidProductName()
        {
            string expectedResultNoSuchItem = "Produktų nerasta.";
            string input = "hello";

            Parduotuve.ClickBurgerMenu();
            Parduotuve.SendKeysToSearchfield(input);
            string actualSearchResultText = Parduotuve.GetSearchResultNoSuchItem();
            Parduotuve.ClickSearchIcon();
            string actualFinalSearchResultText = Parduotuve.GetFinalSearchResultNoSuchItem();

            Assert.AreEqual(expectedResultNoSuchItem, actualSearchResultText, actualFinalSearchResultText);
        }

        [Test]
        public void AddItemToWishlistAndRemoveIt()
        {
            string expectedNotificationAddition = "Produktas pridėtas!";
            string expectedNotificationRemoval = "Product successfully removed.";

            Parduotuve.MoveToAgar();
            Parduotuve.ClickAddToWishlist();
            string actualNotificationAddition = Parduotuve.GetWishlistNotificationText();
            Parduotuve.CLickToSeeWishlist();
            Parduotuve.ClickToRemoveItem();
            string actualNotificationRemoval = Parduotuve.GetProductRemovalFromWishlistConfirm();

            Assert.AreEqual(expectedNotificationAddition, actualNotificationAddition);
            Assert.AreEqual(expectedNotificationRemoval, actualNotificationRemoval);
        }

        [Test]
        public void AddItemToShoppingBasket()
        {
            string expectedResult = "2 × “Ašvaganda (Ashwagandha) milteliai” - įdėti į krepšelį";
            string expectedAlertText = "Pasirinkite produkto savybes prieš pridėdami šį produktą į savo krepšelį.";

            Parduotuve.MoveToAshwagandha();
            Parduotuve.ClickQuickPreview();
            Parduotuve.ClickToBasketButton();
            string actualAlertText = Parduotuve.GetAlertText();
            Parduotuve.AcceptAlert();
            Parduotuve.Click100G();
            Parduotuve.ClickAddMore();
            Parduotuve.ClickToBasketButton();
            string actualResult = Parduotuve.GetBasketNotificationText();

            Assert.AreEqual(expectedAlertText, actualAlertText);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void RemoveItemFromBasketUsingBasketSlideMenu()
        {
            string expectedResult = "Krepšelyje nėra produktų.";
            string quantity = "8";

            Parduotuve.MoveToCashew();
            Parduotuve.ClickCashewQuickPreview();
            Parduotuve.Click450G();
            Parduotuve.ClearQuantityInputField();
            Parduotuve.SendKeysToQuantityInputField(quantity);
            Parduotuve.ClickToBasketButton();
            Parduotuve.ClickBasketIcon();
            Parduotuve.ClickRemoveFromBasketButton();
            string actualResult = Parduotuve.GetProductRemovalFromBasketConfirm();
            Parduotuve.ClickCloseBasketSlide();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
