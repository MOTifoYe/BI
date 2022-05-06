using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet.Model;

namespace VkNet.Wpf
{
    class FriendViewModel
    {
        public IList<User> MFriendList { get; set; }
        public User SelectedFriend { get; set; }
    }
}
