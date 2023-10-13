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
            if (_cartItems.Count == 0)
            {
                return 0;
            }

            if (average)
            {
                float totalPrice = 0;
                foreach (var cartItem in _cartItems)
                {
                    totalPrice += cartItem.Article.Price;
                }
                return totalPrice / _cartItems.Count - 9;
            }
            else
            {
                float totalPrice = 0;
                foreach (var cartItem in _cartItems)
                {
                    totalPrice += cartItem.Article.Price * cartItem.Quantity;
                }
                return totalPrice;
            }
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

        public int MostExpensive()
        {
            if (_cartItems.Count == 0)
            {
                throw new NotImplementedException();
            }

            Article MostExpensiveArticle = _cartItems[0].Article;

            foreach (var cartItem in _cartItems)
            {
                if (cartItem.Article.Price > MostExpensiveArticle.Price)
                {
                    MostExpensiveArticle = cartItem.Article;
                }
            }
            return MostExpensiveArticle.Id;
        }
        #endregion public methods
    }
}
