using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelLibrary
{
    public partial class ComponentDecorator : Component
    {
        public ComponentDecorator()
        {
            InitializeComponent();
        }

        public ComponentDecorator(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public string Name { get; set; }
        public ProviderDecorator GetProviderDecorator(Event ev, Provider provider){
            switch (ev)
            {
                case Event.BADQUALITY:
                     return new BadProvider(provider);
                case Event.EARLY:
                     return new EarlyProvider(provider);
                case Event.GOODQUALITY:
                    return new GoodProvider(provider);
                case Event.LATE:
                    return new LateProvider(provider);
                default:
                    throw new Exception("Action not supported");
            }

        }
    }
}
