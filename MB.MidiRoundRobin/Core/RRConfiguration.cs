using System;
using System.Collections.Generic;
using System.Text;

namespace MB.MidiRoundRobin.Core
{
    public class RRConfiguration
    {
        public string MidiIn { get; set; }
        public string MidiOut { get; set; }
        public string MidiChannelsIn { get; set; }
        public string MidiChannelsOut { get; set; }
    }
}
