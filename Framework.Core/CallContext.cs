using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core
{
    public class CallContext
    {

        public const string BusinessKey = "business";
        public const string ChannelKey = "channel";
        public const string LanguageKey = "language";
        public const string ProductInstanceKey = "productinstance";
        public const string RegionKey = "region";
        public const string RequestIdKey = "requestId";

        private const string region = "PARIS";
        private string business;
        private string channel;
        private string language;

        public string Business { get { return business; } }
        public string Channel { get { return channel; } }


        public string Language { get { return language; } }

        public string Region { get { return region; } protected set { value = region; } }
       
    }
}
