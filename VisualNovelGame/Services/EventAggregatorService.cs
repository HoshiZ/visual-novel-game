using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualNovelGame.Services
{
    internal class EventAggregatorService
    {
        public class IndexTogoEvent : PubSubEvent<string> { };
    }
}
