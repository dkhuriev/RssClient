using System.Windows.Forms;
using System;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace RssClient
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGetRssButtonClick(object sender, EventArgs e)
        {
            var rssResourceUrl = enterUrlTextBox.Text;
            if (String.IsNullOrEmpty(rssResourceUrl))
                throw new InvalidOperationException("RSS Url не может быть пустым");
            var rssData = GetDataFromRss(rssResourceUrl);
            DisplayRssData(rssData);
        }

        private IEnumerable<RssFeedDataDto> GetDataFromRss(string rssResourceUrl)
        {
            if (string.IsNullOrEmpty(rssResourceUrl))
                throw new ArgumentException("message", nameof(rssResourceUrl));

            var webClient = new RestClient(backendUrl);
            var request = new RestRequest("rss");
            request.AddParameter("link", rssResourceUrl);

            var response = webClient.Get<List<RssFeedDataDto>>(request);
            if (response.StatusCode != HttpStatusCode.OK)
                throw new InvalidOperationException("Не удалось получить информацию из RSS канала");
            return response.Data;
        }

        private void DisplayRssData(IEnumerable<RssFeedDataDto> rssData)
        {
            rssDataRichTextBox.Text = string.Concat(rssData.Select(item => item.ToString()));
            Controls.Add(rssDataRichTextBox);

            FilterComboBox.Items.AddRange(new[] { "Дата добавления", "Размер описания", "По ключевым словам" });
            Controls.Add(FilterComboBox);

            _rssData = rssData;
        }

        private const string backendUrl = "http://localhost:5000/";

        private void OnFilterComboBoxSelect(object sender, EventArgs e)
        {
            var selectedFilter = FilterComboBox.SelectedItem.ToString();

            if (_rssData == null)
                throw new InvalidOperationException();

            switch (selectedFilter)
            {
                case "Дата добавления":
                    _rssData = _rssData.OrderBy(item => item.PublicationDate);
                    break;
                case "Размер описания":
                    _rssData = _rssData.Where(item => item.Description != null).OrderBy(item => item.Description.Length);
                    break;
                case "По ключевым словам":
                    break;
            }

            rssDataRichTextBox.Text = string.Concat(_rssData.Select(item => item.ToString()));
        }

        private IEnumerable<RssFeedDataDto> _rssData;
    }
}
