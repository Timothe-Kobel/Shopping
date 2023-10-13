namespace Shopping
{
    public class Article
    {
        #region private attributes
        private int _id;
        private string _description = "";
        private float _price = 0f;
        #endregion private attributes

        #region public methods
        public Article(int id, string description, float price)
        {
            throw new NotImplementedException();
        }

        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Description
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

        public float Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion public methods

        public class ArticleException : Exception { }
        public class TooShortDescriptionException : ArticleException { }
        public class SpecialCharInDescriptionException : ArticleException { }
        public class TooLongDescriptionException : ArticleException { }
    }
}
