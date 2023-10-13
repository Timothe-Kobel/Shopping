namespace Shopping
{
    public class Cart
    {
        #region private attributes
        private List<CartItem> _cartItems = new List<CartItem>();
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> cartItems)
        {
            _cartItems = cartItems;
        }

        public void Remove(List<CartItem> cartItemsToRemove)
        {
            _cartItems = cartItemsToRemove;
            cartItemsToRemove.Clear();
        }

        public List<CartItem> CartItems
        {
            get
            {
                return _cartItems;
            }
        }

        public float Price(bool average = false)
        {
            throw new NotImplementedException();
        }

        public bool DoesExist(int itemId)
        {
            if (_cartItems.Any(cartItem => cartItem.Article.Id == itemId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Cheapest()
        {
            if (_cartItems.Count == 0)
            {
                throw new NotImplementedException();
            }

            Article cheapestArticle = _cartItems[0].Article;

            foreach (var cartItem in _cartItems)
            {
                if (cartItem.Article.Price < cheapestArticle.Price)
                {
                    cheapestArticle = cartItem.Article;
                }
            }
            return cheapestArticle.Id;
        }
        #endregion public methods
    }
}
