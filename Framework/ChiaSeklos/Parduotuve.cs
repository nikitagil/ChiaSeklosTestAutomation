namespace Framework.ChiaSeklos
{
    public class Parduotuve
    {
        private static string url = "https://chiaseklos.lt/parduotuve/";
        private static string mainMenuLocator = "//*[@data-open='#main-menu']//*[@class='icon-menu']";
        private static string searchfieldLocator = "//*[@id='main-menu']//*[@type='search']";
        private static string clickResultLocator = "//*[@class='autocomplete-suggestion']";
        private static string agarLocator = "//*[contains(text(),'agar')]";
        private static string agarAddToWishlistLocator = "(//*[@class='icon-heart'])[1]";
        private static string itemAddedToWishlistNotificationLocator = "//*[@id='yith-wcwl-message']";
        private static string agarGoToWishlistLocator = "//*[@class='yith-wcwl-wishlistaddedbrowse show']";
        private static string removeItemFromWishlistLocator = "//*[@title='Remove this product']";
        private static string removalFromWishlistConfirmLocator = "//*[@class='woocommerce-message message-wrapper']";
        private static string ashwagandhaLocator = "//*[contains(text(),'Ašvaganda')]";
        private static string ashwagandhaQuickPreviewLocator = "//*[@data-prod='13703']";
        private static string basketButtonLocator = "//*[@class='single_variation_wrap']//*[@type='submit']";
        private static string addMoreLocator = "//*[@value='+']";
        private static string q100GLocator = "//*[@title='100 g.']//*[contains(text(),'100 g.')]";
        private static string basketNotificationTextLocator = "//*[contains(@class, 'success')]";
        private static string searchResultNoSuchItemLocator = "//*[@class='search-name']";
        private static string searchIconLocator = "//*[@class='mfp-content']//*[@class='icon-search']";
        private static string searchFinalResultNoSuchItemLocator = "//*[@class='woocommerce-info']";
        private static string cashewLocator = "//*[contains(text(),'Anakardžių')]";
        private static string cashewQuickPreviewLocator = "//*[@data-prod='17240']";
        private static string q450GLocator = "//*[@title='450g']";
        private static string quantityInputFieldLocator = "//*[@type='number']";
        private static string basketIconLocator = "(//*[@class='icon-shopping-basket'])[2]";
        private static string removeFromBasketButtonLocator = "//*[contains(@class,'remove')]";
        private static string removalFromBasketConfirmLocator = "//*[contains(@class,'woocommerce-mini-cart')]";
        private static string closeBasketLocator = "//*[contains(@title,'Close')]";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void ClickBurgerMenu()
        {
            Common.ClickElement(mainMenuLocator);
        }

        public static void SendKeysToSearchfield(string searchword)
        {
            Common.SendKeysToElement(searchfieldLocator, searchword);
        }

        public static void ClickSearchResult()
        {
            Common.WaitForElementToBeVisible(clickResultLocator);
            Common.ClickElement(clickResultLocator);
        }

        public static void MoveToAgar()
        {
            Common.MovetoElement(agarLocator);
        }

        public static void ClickAddToWishlist()
        {
            Common.ClickElement(agarAddToWishlistLocator);
        }

        public static string GetWishlistNotificationText()
        {
            Common.WaitForElementToBeVisible(itemAddedToWishlistNotificationLocator);
            return Common.GetElementText(itemAddedToWishlistNotificationLocator);
        }

        public static void CLickToSeeWishlist()
        {
            Common.ClickElement(agarGoToWishlistLocator);
        }

        public static void ClickToRemoveItem()
        {
            Common.WaitForElementToBeVisible(removeItemFromWishlistLocator);
            Common.ClickElement(removeItemFromWishlistLocator);
        }

        public static string GetProductRemovalFromWishlistConfirm()
        {
            Common.WaitForElementToBeVisible(removalFromWishlistConfirmLocator);
            return Common.GetElementText(removalFromWishlistConfirmLocator);
        }

        public static void MoveToAshwagandha()
        {
            Common.MovetoElement(ashwagandhaLocator);
        }

        public static void ClickQuickPreview()
        {
            Common.WaitForElementToBeVisible(ashwagandhaQuickPreviewLocator);
            Common.ClickElement(ashwagandhaQuickPreviewLocator);
        }

        public static void ClickToBasketButton()
        {
            Common.WaitForElementToBeVisible(basketButtonLocator);
            Common.ClickElement(basketButtonLocator);
        }

        public static string GetAlertText()
        {
            return Common.GetAlertText();
        }

        public static void AcceptAlert()
        {
            Common.AcceptAlert();
        }

        public static void Click100G()
        {
            Common.ClickElement(q100GLocator);
        }

        public static void ClickAddMore()
        {
            Common.ClickElement(addMoreLocator);
        }

        public static string GetBasketNotificationText()
        {
            Common.WaitForElementToBeVisible(basketNotificationTextLocator);
            return Common.GetElementText(basketNotificationTextLocator);
        }

        public static string GetSearchResultNoSuchItem()
        {
            Common.WaitForElementToBeVisible(searchResultNoSuchItemLocator);
            return Common.GetElementText(searchResultNoSuchItemLocator);
        }

        public static void ClickSearchIcon()
        {
            Common.ClickElement(searchIconLocator);
        }

        public static string GetFinalSearchResultNoSuchItem()
        {
            return Common.GetElementText(searchFinalResultNoSuchItemLocator);
        }

        public static void MoveToCashew()
        {
            Common.MovetoElement(cashewLocator);
        }

        public static void ClickCashewQuickPreview()
        {
            Common.ClickElement(cashewQuickPreviewLocator);
        }

        public static void Click450G()
        {
            Common.WaitForElementToBeVisible(q450GLocator);
            Common.ClickElement(q450GLocator);
        }

        public static void SendKeysToQuantityInputField(string quantity)
        {
            Common.SendKeysToElement(quantityInputFieldLocator, quantity);
        }

        public static void ClearQuantityInputField()
        {
            Common.ClearInputElement(quantityInputFieldLocator);
        }

        public static void ClickBasketIcon()
        {
            Common.ClickElement(basketIconLocator);
        }

        public static void ClickRemoveFromBasketButton()
        {
            Common.WaitForElementToBeVisible(removeFromBasketButtonLocator);
            Common.ClickElement(removeFromBasketButtonLocator);
        }

        public static string GetProductRemovalFromBasketConfirm()
        {
            Common.WaitForSeconds();
            return Common.GetElementText(removalFromBasketConfirmLocator);
        }

        public static void ClickCloseBasketSlide()
        {
            Common.ClickElement(closeBasketLocator);
        }
    }
}
