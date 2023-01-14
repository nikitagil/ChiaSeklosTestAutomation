namespace Framework.ChiaSeklos
{
    public class Parduotuve
    {
        private static string url = "https://chiaseklos.lt/parduotuve/";
        private static string MainMenuLocator = "//*[@data-open='#main-menu']//*[@class='icon-menu']";
        private static string SearchfieldLocator = "//*[@id='main-menu']//*[@type='search']";
        private static string ClickResultLocator = "//*[@class='autocomplete-suggestion']";
        private static string AgarLocator = "//*[contains(text(),'agar')]";
        private static string AgarAddToWishlistLocator = "(//*[@class='icon-heart'])[1]";
        private static string ItemAddedToWishlistNotificationLocator = "//*[@id='yith-wcwl-message']";
        private static string AgarGoToWishlistLocator = "//*[@class='yith-wcwl-wishlistaddedbrowse show']";
        private static string RemoveItemFromWishlistLocator = "//*[@title='Remove this product']";
        private static string RemovalFromWishlistConfirmLocator = "//*[@class='woocommerce-message message-wrapper']";
        private static string AshwagandhaLocator = "//*[contains(text(),'Ašvaganda')]";
        private static string AshwagandhaQuickPreviewLocator = "//*[@data-prod='13703']";
        private static string BasketButtonLocator = "//*[@class='single_variation_wrap']//*[@type='submit']";
        private static string AddMoreLocator = "//*[@value='+']";
        private static string Q100GLocator = "//*[@title='100 g.']//*[contains(text(),'100 g.')]";
        private static string BasketNotificationTextLocator = "//*[contains(@class, 'success')]";
        private static string SearchResultNoSuchItemLocator = "//*[@class='search-name']";
        private static string SearchIconLocator = "//*[@class='mfp-content']//*[@class='icon-search']";
        private static string SearchFinalResultNoSuchItemLocator = "//*[@class='woocommerce-info']";
        private static string CashewLocator = "//*[contains(text(),'Anakardžių')]";
        private static string CashewQuickPreviewLocator = "//*[@data-prod='17240']";
        private static string Q450GLocator = "//*[@title='450g']";
        private static string QuantityInputFieldLocator = "//*[@type='number']";
        private static string BasketIconLocator = "(//*[@class='icon-shopping-basket'])[2]";
        private static string RemoveFromBasketButtonLocator = "//*[contains(@class,'remove')]";
        private static string RemovalFromBasketConfirmLocator = "//*[contains(@class,'woocommerce-mini-cart')]";
        private static string CloseBasketLocator = "//*[contains(@title,'Close')]";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void ClickBurgerMenu()
        {
            Common.ClickElement(MainMenuLocator);
        }

        public static void ClickSearchfield()
        {
            Common.WaitForElementToBeVisible(SearchfieldLocator);
            Common.ClickElement(SearchfieldLocator);
        }

        public static void SendKeysToSearchfield(string searchword)
        {
            Common.SendKeysToElement(SearchfieldLocator, searchword);
        }

        public static void ClickSearchResult()
        {
            Common.WaitForElementToBeVisible(ClickResultLocator);
            Common.ClickElement(ClickResultLocator);
        }

        public static void MoveToAgar()
        {
            Common.MovetoElement(AgarLocator);
        }

        public static void ClickAddToWishlist()
        {
            Common.ClickElement(AgarAddToWishlistLocator);
        }

        public static string GetWishlistNotificationText()
        {
            Common.WaitForElementToBeVisible(ItemAddedToWishlistNotificationLocator);
            return Common.GetElementText(ItemAddedToWishlistNotificationLocator);
        }

        public static void CLickToSeeWishlist()
        {
            Common.ClickElement(AgarGoToWishlistLocator);
        }

        public static void ClickToRemoveItem()
        {
            Common.WaitForElementToBeVisible(RemoveItemFromWishlistLocator);
            Common.ClickElement(RemoveItemFromWishlistLocator);
        }

        public static string GetProductRemovalFromWishlistConfirm()
        {
            Common.WaitForElementToBeVisible(RemovalFromWishlistConfirmLocator);
            return Common.GetElementText(RemovalFromWishlistConfirmLocator);
        }

        public static void MoveToAshwagandha()
        {
            Common.MovetoElement(AshwagandhaLocator);
        }

        public static void ClickQuickPreview()
        {
            Common.WaitForElementToBeVisible(AshwagandhaQuickPreviewLocator);
            Common.ClickElement(AshwagandhaQuickPreviewLocator);
        }

        public static void ClickToBasketButton()
        {
            Common.WaitForElementToBeVisible(BasketButtonLocator);
            Common.ClickElement(BasketButtonLocator);
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
            Common.ClickElement(Q100GLocator);
        }

        public static void ClickAddMore()
        {
            Common.ClickElement(AddMoreLocator);
        }

        public static string GetBasketNotificationText()
        {
            Common.WaitForElementToBeVisible(BasketNotificationTextLocator);
            return Common.GetElementText(BasketNotificationTextLocator);
        }

        public static string GetSearchResultNoSuchItem()
        {
            Common.WaitForElementToBeVisible(SearchResultNoSuchItemLocator);
            return Common.GetElementText(SearchResultNoSuchItemLocator);
        }

        public static void ClickSearchIcon()
        {
            Common.ClickElement(SearchIconLocator);
        }

        public static string GetFinalSearchResultNoSuchItem()
        {
            return Common.GetElementText(SearchFinalResultNoSuchItemLocator);
        }

        public static void MoveToCashew()
        {
            Common.MovetoElement(CashewLocator);
        }

        public static void ClickCashewQuickPreview()
        {
            Common.ClickElement(CashewQuickPreviewLocator);
        }

        public static void Click450G()
        {
            Common.WaitForElementToBeVisible(Q450GLocator);
            Common.ClickElement(Q450GLocator);
        }

        public static void ClickQuantityInputField()
        {
            Common.ClickElement(QuantityInputFieldLocator);
        }

        public static void SendKeysToQuantityInputField(string quantity)
        {
            Common.SendKeysToElement(QuantityInputFieldLocator, quantity);
        }

        public static void ClearQuantityInputField()
        {
            Common.ClearInputElement(QuantityInputFieldLocator);
        }

        public static void ClickBasketIcon()
        {
            Common.ClickElement(BasketIconLocator);
        }

        public static void ClickRemoveFromBasketButton()
        {
            Common.WaitForElementToBeVisible(RemoveFromBasketButtonLocator);
            Common.ClickElement(RemoveFromBasketButtonLocator);
        }

        public static string GetProductRemovalFromBasketConfirm()
        {
            Common.WaitForSeconds();
            return Common.GetElementText(RemovalFromBasketConfirmLocator);
        }

        public static void ClickCloseBasketSlide()
        {
            Common.ClickElement(CloseBasketLocator);
        }
    }
}
