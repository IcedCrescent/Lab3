using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.models
{
    class Copy
    {
        private int _copyCode;
        private int _bookCode;
        private int _copyNumber;
        private int _sequenceNumber;
        private string _type;
        private int _price;

        public int CopyCode
        {
            get
            {
                return _copyCode;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Copy code can't be negative!");
                _copyCode = value;
            }
        }

        public int BookCode
        {
            get
            {
                return _bookCode;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Book code can't be negative!");
                _bookCode = value;
            }
        }

        public int CopyNumber
        {
            get
            {
                return _copyNumber;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Copy Number can't be negative!");
                _copyNumber = value;
            }
        }

        public int SequenceNumber
        {
            get
            {
                return _sequenceNumber;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Sequence Number can't be negative!");
                }
                _sequenceNumber = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public int Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Price can't be negative!");
                _price = value;
            }
        }
    }
}
