using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using VkNet.Abstractions.Authorization;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.NLog.Extensions.Logging;
using VkNet.NLog.Extensions.Logging.Extensions;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace VkNet.Wpf
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		private VkApi _api;
		private readonly FriendViewModel friendViewModel;
		private static readonly ulong client_id = 8142517;
		private static readonly ulong client_id_vk = 6287487;
		public MainWindow()
		{
			InitializeComponent();
			this.friendViewModel = new FriendViewModel
			{
				MFriendList = new ObservableCollection<User>()
			};
			this.DataContext = this.friendViewModel;
			


		}

		private void Window_Initialized(object sender, System.EventArgs e)
		{
			_api = new VkApi(InitDi());

			if (_api.IsAuthorized)
			{
				return;
			}

			_api.Authorize(new ApiAuthParams
			{
				ApplicationId = client_id_vk,
				Settings = Settings.All
			});
		}

		private static ServiceCollection InitDi()
		{
			var di = new ServiceCollection();

			di.AddSingleton<IAuthorizationFlow, WpfAuthorize>();
			di.AddSingleton<ILoggerFactory, LoggerFactory>();
			di.AddSingleton(typeof(ILogger<>), typeof(Logger<>));
			di.AddLogging(builder =>
			{
				builder.ClearProviders();
				builder.SetMinimumLevel(LogLevel.Trace);
				builder.AddNLog(new NLogProviderOptions
				{
					CaptureMessageProperties = true,
					CaptureMessageTemplates = true
				});
			});
			LogManager.LoadConfiguration("nlog.config");

			return di;
		}

		private void GetCountGroups(object sender, RoutedEventArgs e)
		{
			var tmp = _api.Groups.Get(new GroupsGetParams());
			MessageBox.Show(tmp.TotalCount.ToString());
		}

        private void SendMessage(object sender, RoutedEventArgs e)
        {
			_api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams
			{
				PeerId = _api.UserId.Value,
				RandomId = new System.Random().Next(100),
				Message = "MEssAGE"
			});
		}

		private void ShowFriends(object sender, RoutedEventArgs e)
        {
			var friends = _api.Friends.Get(new FriendsGetParams
			{
				Fields = ProfileFields.All
			});

			foreach (var friend in friends)
			{
				this.friendViewModel.MFriendList.Add(friend);
			}
		}
		private void ClearTrV(object sender, RoutedEventArgs e) { this.friendViewModel.MFriendList.Clear(); }
		








	}
}