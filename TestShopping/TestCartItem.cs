using Shopping;
using static Shopping.CartItem;

namespace TestShopping
{
    public class TestCartItem
    {
        #region private attributes
        private CartItem? _cartItem = null;
        private float _price = 0f;
        private int _quantity = 0;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            List<Article> articles = ArticleGenerator.Generate(1);
            _quantity = 1;
            _cartItem = new CartItem(articles[0], _quantity);
        }

        [Test]
        public void AllProperties_AfterInstantiation_Success()
        {
            //given
            //refer to Setup
            _price = 2.0f;

            //when
            //Event will be triggered by constructor

            //then
            Assert.AreEqual(_price, _cartItem.Article.Price);
            Assert.AreEqual(_quantity, _cartItem.Quantity);
        }

        [Test]
        public void SetQuantity_CorrectValue_GetNewValue()
        {
            //given
            int expectedQuantity = 2;

            //when
            _cartItem.Quantity = expectedQuantity;

            //then
            Assert.AreEqual(_cartItem.Quantity, expectedQuantity);
        }

        [Test]
        public void SetQuantity_WrongValue_ThrowException()
        {
            //given
            int expectedQuantity = -2;

            //when
            Assert.Throws<WrongQuantityException>(() => _cartItem.Quantity = expectedQuantity);
            
            //then
            //throws exception
        }
    }
}