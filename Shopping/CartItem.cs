namespace Shopping
{
    public class CartItem
    {
        #region private attributes
        private Article? _article = null;
        private int _quantity = 0;
        #endregion private attributes

        #region public methods
        public CartItem(Article article, int quantity)
        {
            _article = article;
            _quantity = quantity;
        }

        public Article? Article
        {
            get
            {
                return _article;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new WrongQuantityException();
                }
                _quantity = value;
            }
        }
        #endregion public methods

        public class CartItemException : Exception { }
        public class WrongQuantityException : CartItemException { }
    }
}
