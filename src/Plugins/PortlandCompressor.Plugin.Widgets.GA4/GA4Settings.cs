using PortlandCompressor.Plugin.Widgets.GA4.Models;
using Nop.Core.Configuration;

namespace PortlandCompressor.Plugin.Widgets.GA4
{
    public class GA4Settings : ISettings
    {
        public string GoogleTag { get; set; }
        public bool IsDebugMode { get; set; }
    }
}