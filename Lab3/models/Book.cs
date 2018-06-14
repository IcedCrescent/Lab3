using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.models
{
    class Book
    {
        private int _bookCode;
        private string _title;
        private string _author;
        private string _publisher;

        public int BookCode
        {
            get
            {
                return _bookCode;
            }

            set
            {
                _bookCode = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
            }
        }

        public string Publisher
        {
            get
            {
                return _publisher;
            }

            set
            {
                _publisher = value;
            }
        }
    }
}
