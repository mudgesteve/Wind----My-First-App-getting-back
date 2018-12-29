using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind
{
    public class UserInformation : Common.ObservableBase
    {
        private string _displayName;
        public string DisplayName
        {
            get { return this._displayName; }
            set { this.SetProperty(ref this._displayName, value); }
        }

        private string _bioContent;
        public string BioContent
        {
            get { return this._bioContent; }
            set { this.SetProperty(ref this._bioContent, value); }
        }

        private string _profileImageUrl;
        public string ProfileImageUrl
        {
            get { return this._profileImageUrl; }
            set { this.SetProperty(ref this._profileImageUrl, value); }
        }

       
    }
}
