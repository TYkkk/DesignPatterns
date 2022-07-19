using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_BridgePattern
{
    class BridgePattern
    {
    }

    abstract class TV
    {
        public abstract void On();

        public abstract void Off();

        public abstract void Next();
    }

    class ChangHongTV : TV
    {
        public override void On() { }

        public override void Off() { }

        public override void Next() { }
    }

    abstract class RemoteControl
    {
        protected TV targetTV;

        public abstract void OpenBtnEvent();

        public abstract void CloseBtnEvent();

        public abstract void NextBtnEvent();

        public abstract void SetTV(TV target);
    }

    class ChangHongRemoteControl : RemoteControl
    {
        public override void CloseBtnEvent()
        {
            targetTV.Off();
        }

        public override void NextBtnEvent()
        {
            targetTV.Next();
        }

        public override void OpenBtnEvent()
        {
            targetTV.On();
        }

        public override void SetTV(TV target)
        {
            targetTV = target;
        }
    }
}
