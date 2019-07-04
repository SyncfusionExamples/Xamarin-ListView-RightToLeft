using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ListViewRTL
{
    public class Model : INotifyPropertyChanged
    {
        #region Fields

        private int bookNo;
        private string bookName;
        private string bookDesc;
        private int contactNo;
        private string contactName;
        private string contactNumber;

        #endregion
        
        #region Constructor

        public Model()
        {

        }

        #endregion

        #region Properties

        public int BookNo
        {
            get { return bookNo; }
            set
            {
                bookNo = value;
                OnPropertyChanged("BookNo");
            }
        }

        public string BookName
        {
            get { return bookName; }
            set
            {
                bookName = value;
                OnPropertyChanged("BookName");
            }
        }

        public string BookDescription
        {
            get { return bookDesc; }
            set
            {
                bookDesc = value;
                OnPropertyChanged("BookDescription");
            }
        }

        public int ContactNo
        {
            get { return contactNo; }
            set
            {
                contactNo = value;
                OnPropertyChanged("ContactNo");
            }
        }

        public string ContactName
        {
            get { return contactName; }
            set
            {
                contactName = value;
                OnPropertyChanged("ContactName");
            }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                contactNumber = value;
                OnPropertyChanged("ContactNumber");
            }
        }

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }


}
