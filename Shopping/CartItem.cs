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
            throw new NotImplementedException();
        }

        public Article Article
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Quantity
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        #endregion public methods

        public class CartItemException : Exception { }
        public class WrongQuantityException : CartItemException { }
    }
}
