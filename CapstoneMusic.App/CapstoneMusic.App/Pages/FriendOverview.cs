using CapstoneMusic.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneMusic.App.Pages
{
    public partial class FriendOverview
    { 
		public FriendOverview()
        {
			InitializeFriends();
        }
        public IEnumerable<Friend> Friends { get; set; }

		private void InitializeFriends()
		{
			var friend1 = new Friend
			{
				FirstName = "Mikayla",
				LastName = "McGraw",
				PlaylistCount = 3,
				SongCount = 30

			};

			var friend2 = new Friend
			{
				FirstName = "Paige",
				LastName = "Branam",
				PlaylistCount = 5,
				SongCount = 50

			};

			var friend3 = new Friend
			{
				FirstName = "Garrett",
				LastName = "Woodard",
				PlaylistCount = 1,
				SongCount = 5

			};
			Friends = new List<Friend> { friend1, friend2, friend3 };
		}

	}
}
